using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using halisahaapp.business.Abstract;
using halisahaapp.business.Concrete;
using halisahaapp.data.Abstract;
using halisahaapp.data.Concrete.EfCore;
using halisahaapp.webui.EmailServices;
using halisahaapp.webui.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;

namespace halisahaapp.webui
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        private IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>(options => options.UseMySql(_configuration.GetConnectionString("MySqlConnection")));
            services.AddDbContext<HalisahaContext>();


            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                // password
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = false;

                // Lockout                
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15);
                options.Lockout.AllowedForNewUsers = true;

                // options.User.AllowedUserNameCharacters = "";
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = true;
                options.SignIn.RequireConfirmedPhoneNumber = false;
            });

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/auth/login";
                options.LogoutPath = "/auth/logout";
                options.AccessDeniedPath = "/auth/accessdenied";
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = TimeSpan.FromDays(1);
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true,
                    Name = ".HalisahaApp.Security.Cookie",
                    SameSite = SameSiteMode.Strict
                };
            });


            services.AddScoped<IEmailSender, SmtpEmailSender>(i =>
                new SmtpEmailSender(
                    _configuration["EmailSender:host"],
                    _configuration.GetValue<int>("EmailSender:port"),
                    _configuration.GetValue<bool>("EmailSender:enableSSL"),
                    _configuration["EmailSender:userName"],
                    _configuration["EmailSender:password"])
               );
            services.AddScoped<IHalisahaService, HalisahaManager>();
            services.AddScoped<IHalisahaRepository, EfCoreHalisahaRepository>();

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(), "node_modules")),
                RequestPath = "/modules"

            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                 endpoints.MapControllerRoute(
                   name: "userlist",
                   pattern: "admin/user/user-list",
                   defaults: new { controller = "Admin", action = "GetAllUser" }
                );
                endpoints.MapControllerRoute(
                   name: "userprofile",
                   pattern: "user/{userName}",
                   defaults: new { controller = "User", action = "UserProfile" }
                );
                endpoints.MapControllerRoute(
                   name: "registerhalisaha",
                   pattern: "halisaha/register/request",
                   defaults: new { controller = "Halisaharezerve", action = "RegisterHalisaha" }
                );
                endpoints.MapControllerRoute(
                   name: "pretranasaction",
                   pattern: "auth/{pre-transaction}",
                   defaults: new { controller = "Auth", action = "PreTransaction" }
                );
                //--------------------
                endpoints.MapControllerRoute(
                    name: "listallhalisahaincity",
                    pattern: "halisaha/{city}",
                    defaults: new { controller = "Halisaha", action = "ListAllHalisahaInCity" }
                 );
                endpoints.MapControllerRoute(
                    name: "halisahapayment",
                    pattern: "halisaha/{city}/{halisahaId}/{slug}/{date}/{time}/reservation",
                    defaults: new { controller = "Halisaharezerve", action = "Payment" }
                 );
                endpoints.MapControllerRoute(
                   name: "gethalisahapage",
                   pattern: "halisaha/{city}/{halisahaId}/{slug}",
                   defaults: new { controller = "Halisaharezerve", action = "GetHalisahaPage" }
                );
                //--------halisaha
                endpoints.MapControllerRoute(
                   name: "edithalisaha",
                   pattern: "halisaha/{id}/editHalisaha",
                   defaults: new { controller = "Halisaha", action = "EditHalisaha" }
                );

                endpoints.MapControllerRoute(
                   name: "registerhalisaha",
                   pattern: "halisaha/register/control",
                   defaults: new { controller = "Halisaha", action = "RegisterHalisaha" }
                );




                //-------------
                //  endpoints.MapControllerRoute(
                //     name: "addproperty",
                //     pattern: "halisaha/addProperty",
                //     defaults: new { controller = "halisaha", action = "AddProperty" }
                // );
                // endpoints.MapControllerRoute(
                //     name: "editaccaunt",
                //     pattern: "auth/editAccount",
                //     defaults: new { controller = "Auth", action = "EditAccount" }
                // );
                endpoints.MapControllerRoute(
                    name: "editaccaunt",
                    pattern: "auth/editAccount",
                    defaults: new { controller = "Auth", action = "EditAccount" }
                );
                endpoints.MapControllerRoute(
                 name: "editphoto",
                 pattern: "auth/editPhoto",
                 defaults: new { controller = "Auth", action = "EditPhoto" }
                 );
                endpoints.MapControllerRoute(
                   name: "editprofile",
                   pattern: "auth/EditProfile",
                   defaults: new { controller = "Auth", action = "EditProfile" }
               );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}"

                );
            });
        }
    }
}
