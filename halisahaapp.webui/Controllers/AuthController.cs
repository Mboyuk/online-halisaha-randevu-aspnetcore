using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using halisahaapp.business.Abstract;
using halisahaapp.entity;
using halisahaapp.webui.EmailServices;
using halisahaapp.webui.Extensions;
using halisahaapp.webui.Identity;
using halisahaapp.webui.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Slugify;

namespace halisahaapp.webui.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class AuthController : Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        private IEmailSender _emailSender;
        private RoleManager<IdentityRole> _roleManager;
        private IHalisahaService _halisahaService;
        public AuthController(UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender, RoleManager<IdentityRole> roleManager, IHalisahaService halisahaService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _roleManager = roleManager;
            _halisahaService = halisahaService;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.UserName
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "user"); // kullanıcı rolü belirlerme
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var url = Url.Action("ConfirmEmail", "Auth", new
                {
                    userId = user.Id,
                    token = code
                });
                await _emailSender.SendEmailAsync(model.Email, "Hesabınızı onaylayınız.", $"Lütfen email hesabınızı onaylamak için linke <a href='https://localhost:5001{url}'>tıklayınız.</a>");

                return RedirectToAction("Login", "Auth");
            }
            
            ModelState.AddModelError("", "Bilinmeyen hata oldu lütfen tekrar deneyiniz.");

            return View(model);
        }

        public IActionResult Login(string ReturnUrl = null)
        {
            var LoginModel = new LoginModel()
            {
                ReturnUrl = ReturnUrl
            };
            return View(LoginModel);
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "bu email kayıtlı değil");
                return View(model);
            }
            if (!await _userManager.IsEmailConfirmedAsync(user))
            {
                ModelState.AddModelError("", "Lütfen email hesabınıza gelen link ile üyeliğinizi onaylayınız.");
                return View(model);
            }

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, false);

            if (result.Succeeded)
            {
                TempData.Put("message", new AlertMessage()
                {
                    Title = "Hoşgeldin, " + user.UserName,
                    Message = "",
                    AlertType = "success"
                });
                return Redirect(model.ReturnUrl ?? "~/");
            }
            ModelState.AddModelError("", "Girilen kullanıcı adı veya parola yanlış");
            return View(model);
        }
        [Authorize]
        public async Task<IActionResult> EditProfile()
        {
            var id = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(id);
            var email = await _userManager.GetEmailAsync(user);
            //await _roleManager.CreateAsync(new IdentityRole("user"));

            //await _userManager.AddToRoleAsync(user,"manager"); // kullanıcı rolü belirlerme
            var profile = new EditProfileModel()
            {
                Email = user.Email,
                NickName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                ImgUrl = user.ImgUrl
            };
            return View(profile);
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> EditProfile(EditProfileModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var userId = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(userId);

            user.FirstName = model.FirstName;
            //user.UserName = model.NickName;
            user.LastName = model.LastName;


            await _userManager.UpdateAsync(user);
            var profile = new EditProfileModel()
            {
                Email = user.Email,
                NickName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                ImgUrl = user.ImgUrl
            };
            TempData.Put("message", new AlertMessage()
            {
                Title = "Tebrikler, " + user.UserName,
                Message = "Profil güncelleme işlemi başarıyla yapıldı",
                AlertType = "success"
            });

            return View(profile);
        }

        [Authorize]
        public async Task<IActionResult> EditPhoto()
        {
            var id = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(id);
            var email = await _userManager.GetEmailAsync(user);
            var profile = new EditProfileModel()
            {
                Email = user.Email,
                NickName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                ImgUrl = user.ImgUrl
            };
            return View(profile);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> EditPhoto(IFormFile file)
        {
            var id = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(id);
            var email = await _userManager.GetEmailAsync(user);
            var profile = new EditProfileModel()
            {
                Email = user.Email,
                NickName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                ImgUrl = user.ImgUrl
            };
            if (file != null)
            {
                var extention = Path.GetExtension(file.FileName);
                var randomName = string.Format($"{Guid.NewGuid()}{extention}");
                // entity.ImageUrl = randomName;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", randomName);
                var userId = _userManager.GetUserId(User);
                var users = await _userManager.FindByIdAsync(userId);
                users.ImgUrl = randomName;
                await _userManager.UpdateAsync(users);

                using (var stream = new FileStream(path, FileMode.Create))
                {

                    await file.CopyToAsync(stream);
                }
            }

            return View(profile);
        }
        [Authorize]
        public async Task<IActionResult> EditAccount()
        {


            var id = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(id);
            var email = await _userManager.GetEmailAsync(user);
            var e = new EditAccountModel()
            {
                Email = email
            };
            var profile = new EditProfileModel()
            {
                Email = user.Email,
                NickName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                ImgUrl = user.ImgUrl
            };
            ViewBag.Profile = profile;

            return View(e);
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> EditAccount(EditAccountModel model)
        {
            var id = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(id);
            var profile = new EditProfileModel()
            {
                Email = user.Email,
                NickName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                ImgUrl = user.ImgUrl
            };
            ViewBag.Profile = profile;

            await _userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
            var editaccaunt = new EditAccountModel()
            {
                Email = user.Email
            };
            return View(editaccaunt);
        }

        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
            {

                return View();
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    // cart objesini oluştur.

                    return View();
                }
            }

            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string Email)
        {
            //-------------------MAİL GİTMİYOR İNCELE BURAYI----------------------
            if (string.IsNullOrEmpty(Email))
            {
                return View();
            }

            var user = await _userManager.FindByEmailAsync(Email);

            if (user == null)
            {
                return View();
            }

            var code = await _userManager.GeneratePasswordResetTokenAsync(user);

            var url = Url.Action("ResetPassword", "Auth", new
            {
                userId = user.Id,
                token = code
            });
            TempData.Put("message", new AlertMessage()
            {
                Title = "Tebrikler",
                Message = "Email gönderme işleminiz başarıyla gerçekleşti. Email Kutunuzu kontrol ediniz.",
                AlertType = "success"
            });

            // email
            await _emailSender.SendEmailAsync(Email, "Reset Password", $"Parolanızı yenilemek için linke <a href='https://localhost:5001{url}'>tıklayınız.</a>");

            return View();
        }
        public IActionResult ResetPassword(string userId, string token)
        {
            if (userId == null || token == null)
            {
                return RedirectToAction("Home", "Index");
            }

            var model = new ResetPasswordModel { Token = token };

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                return RedirectToAction("Home", "Index");
            }

            var result = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);

            if (result.Succeeded)
            {
                return RedirectToAction("Login", "Auth");
            }

            return View(model);
        }
        public IActionResult PreTransaction()
        {

            var rezervations = _halisahaService.GetPreTransactions(_userManager.GetUserId(User));
            List<string>  halisahaIds = new List<string>();
          
            foreach (var item in rezervations)
            {
                var a = _halisahaService.GetHalisahaById(1);
                halisahaIds.Add(a.Name);
            }
            ViewBag.Names = halisahaIds;
            var rezervationsListModel = new RezervationListModel()
            {

                Rezervations = rezervations,

            };

            return View(rezervationsListModel);
        }
        [HttpPost]
        public async Task<IActionResult> PreTransaction(RezervationListModel model, double puan, int halisahaId)
        {
            var userId = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(userId);
            var avgPoint = _halisahaService.GetAvgPoint(halisahaId);
            Console.WriteLine(avgPoint);

            _halisahaService.UpdateAvgPoint(halisahaId,avgPoint);

            Comment comment = new Comment()
            {
                UserId = _userManager.GetUserId(User),
                CommentContent = model.CommentModel.Comment,
                point = puan,
                HalisahaId = halisahaId,
                ImgUrl = user.ImgUrl,
                NickName = user.UserName
            };

            _halisahaService.AddComment(comment);


            return RedirectToAction("PreTransaction");
        }



        [Authorize]
        public async Task<IActionResult> Logout()
        {
            TempData.Put("message", new AlertMessage()
            {
                Title = "Güle Güle",
                Message = "Başarıyla çıkış yapıldıı.",
                AlertType = "success"
            });
            await _signInManager.SignOutAsync();

            return Redirect("/home");
        }
        public IActionResult AccessDenied()
        {
            return View();
        }

    }
}