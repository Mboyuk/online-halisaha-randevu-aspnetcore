using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using halisahaapp.business.Abstract;
using halisahaapp.entity;
using halisahaapp.webui.Extensions;
using halisahaapp.webui.Helper;
using halisahaapp.webui.Identity;
using halisahaapp.webui.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Slugify;

namespace halisahaapp.webui.Controllers
{
    [Authorize(Roles = "manager")]
     [AutoValidateAntiforgeryToken]
    public class HalisahaController : Controller
    {
        private IHalisahaService _halisahaService;
        private UserManager<User> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        public HalisahaController(UserManager<User> userManager, IHalisahaService halisahaService, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _halisahaService = halisahaService;
            _roleManager = roleManager;
        }
        // public IActionResult AddProperty()
        // {
        //     return View();
        // }
        // [HttpPost]
        // public IActionResult AddProperty(string name)
        // {
        //     _halisahaService.AddProperty(name);
        //     return View();
        // }

        public IActionResult RegisterHalisaha()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegisterHalisaha(RegisterHalisahaModel model)
        {
            var id = _userManager.GetUserId(User);
            var checkUser = _halisahaService.GetUserIdByHalisaha(id);
            if (checkUser)
            {
                TempData.Put("message", new AlertMessage()
                {
                    Title = "Hata ",
                    Message = "Halı sahanız mevcut olduğu için tekrar kayıt yapamazsınız.",
                    AlertType = "danger"
                });
                return View();
            }
            SlugHelper helper = new SlugHelper();
            var halisaha = new Halisaha()
            {
                UserId = id,
                Name = model.Name,
                City = model.City.ToLower(),
                Content = model.Content,
                Openning = model.Openning,
                Closing = model.Closing,
                Price = model.Price,
                Slug = helper.GenerateSlug(model.Name)
            };

            _halisahaService.RegisterHalisaha(halisaha);
            return RedirectToAction("RegisterHalisaha");
        }
        public async Task<IActionResult> EditHalisaha(string id)
        {
           
            var UserId = _userManager.GetUserId(User);
           
            if(!string.Equals(UserId,id)){
                TempData.Put("message", new AlertMessage()
                {
                    Title = "Hata ",
                    Message = "Yetkisiz erişim.",
                    AlertType = "danger"
                });
                return Redirect("/auth/accessdenied");
            }
            var halisahaId = _halisahaService.GetHalisahaIdByUserId(id);//or  var UserId = _userManager.GetUserId(User);
            if(halisahaId == 0)
            {
                TempData.Put("message", new AlertMessage()
                {
                    Title = "Halı saha kayıt hatası ",
                    Message = "Öncelikle kayıt olmanız gerekmektedir.",
                    AlertType = "danger"
                });
                return Redirect("/");
            }
              ViewBag.AvgPoint = _halisahaService.GetAvgPoint(halisahaId);
            var user = await _userManager.FindByIdAsync(id);
            var halisaha = _halisahaService.GetHalisaha(UserId);
            var rezervations = _halisahaService.GetHalisahaRezervations(halisahaId);
            if (rezervations == null)
            {
                return View();
            }
            //var properties = _halisahaService.GetAllProperties();
            // var selectedProp =_halisahaService.GetSelectedProperties(1);
            ViewBag.Images = _halisahaService.GetHalisahaImages(halisahaId);
            var a = new DateHelper();
            var c = a.createDynamicTable(rezervations);
            ViewBag.Dates = a.getDateTime();
            ViewBag.Url = _halisahaService.GetHalisahaById(halisahaId);
            ViewBag.aa = c;

            if (halisaha != null)
            {
                var selectedProperties = _halisahaService.GetSelectedProperties(halisahaId);
                var properties = _halisahaService.GetAllProperties();

                ViewBag.Properties = properties;
                return View(new EditHalisahaModel()
                {
                    UserId = halisaha.UserId,
                    Name = halisaha.Name,
                    City = halisaha.City,
                    Content = halisaha.Content,
                    Openning = halisaha.Openning,
                    Closing = halisaha.Closing,
                    Price = halisaha.Price,
                    SelectedProperties = selectedProperties.Select(i => i.Property.PropertyName)
                });
            }

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> EditHalisaha(string[] selectedPropertiess)
        {




            var UserId = _userManager.GetUserId(User);
            var halisahaId = _halisahaService.GetHalisahaIdByUserId(UserId);//or  var UserId = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(UserId);

            if (user != null)
            {
                var selectedProperties = _halisahaService.GetSelectedProperties(halisahaId);
                var properties = _halisahaService.GetAllProperties();

                ViewBag.Properties = properties;
                return View(new EditHalisahaModel()
                {

                    SelectedProperties = selectedProperties.Select(i => i.Property.PropertyName)
                });
            }

            return View();
        }
        [HttpPost]
        public IActionResult AddProperties(string[] selectedPropertiess)
        {
            var UserId = _userManager.GetUserId(User);
            var halisahaId = _halisahaService.GetHalisahaIdByUserId(UserId);//or  var UserId = _userManager.GetUserId(User);
            _halisahaService.AddPropertyForHalisaha(halisahaId, selectedPropertiess);
            return Redirect($"/Halisaha/{UserId}/editHalisaha");
        }
        [HttpPost]
        public IActionResult UpdateHalisahaPrice(int price)
        {
            var UserId = _userManager.GetUserId(User);
            _halisahaService.UpdatePrice(UserId, price);

            return Redirect($"/Halisaha/{UserId}/editHalisaha");
        }
        [HttpPost]
        public IActionResult UpdateHalisahaMessage(string Content)
        {
            var UserId = _userManager.GetUserId(User);
            _halisahaService.UpdateMessage(UserId, Content);

            return Redirect($"/Halisaha/{UserId}/editHalisaha");
        }
        [HttpPost]
        public async Task<IActionResult> UpdateHalisahaImages(IFormFile Imagefile)
        {

            var UserId = _userManager.GetUserId(User);

            if (Imagefile != null)
            {
                var halisahaId = _halisahaService.GetHalisahaIdByUserId(UserId);
                var extention = Path.GetExtension(Imagefile.FileName);
                var randomName = string.Format($"{Guid.NewGuid()}{extention}");
                _halisahaService.UpdateImage(halisahaId, randomName);

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\halisahaImage", randomName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await Imagefile.CopyToAsync(stream);
                }

            }

            return Redirect($"/Halisaha/{UserId}/editHalisaha");
        }
        [AllowAnonymousAttribute]
        public IActionResult ListAllHalisahaInCity(string city)
        {
            var halisahas = _halisahaService.GetAllHalisahaInCity(city);
            
            var halisahaModel = new HalisahaModel()
            {
                Halisahas = halisahas
            };
            return View(halisahaModel);
        }

        // public IActionResult GetHalisahaPage()
        // {
        //     return View();
        // }

    }
}