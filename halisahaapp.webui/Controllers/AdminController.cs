using System;
using halisahaapp.business.Abstract;
using halisahaapp.webui.EmailServices;
using halisahaapp.webui.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace halisahaapp.webui.Controllers
{
    [Authorize(Roles ="admin")]
    public class AdminController : Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        private IEmailSender _emailSender;
        private RoleManager<IdentityRole> _roleManager;
        private IHalisahaService _halisahaService;
        public AdminController(UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender, RoleManager<IdentityRole> roleManager, IHalisahaService halisahaService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _roleManager = roleManager;
            _halisahaService = halisahaService;
        }

        public IActionResult AddProperty()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProperty(string name)
        {
            _halisahaService.AddProperty(name);
            return View();
        }

        public IActionResult GetAllUser()
        {
            var users = _userManager.Users;
            foreach (var item in users)
            {
                Console.WriteLine(item.Email);
            }
            return View(users);
        }
    }
}