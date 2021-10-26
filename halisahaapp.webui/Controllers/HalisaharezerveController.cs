using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using halisahaapp.business.Abstract;
using halisahaapp.entity;
using halisahaapp.webui.Helper;
using halisahaapp.webui.Identity;
using halisahaapp.webui.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace halisahaapp.webui.Controllers
{
     [AutoValidateAntiforgeryToken]
    public class HalisaharezerveController : Controller
    {
        private IHalisahaService _halisahaService;
        private UserManager<User> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        public HalisaharezerveController(UserManager<User> userManager, IHalisahaService halisahaService, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _halisahaService = halisahaService;
            _roleManager = roleManager;
        }
       
        public IActionResult GetHalisahaPage(int halisahaId, int page = 1)
        {
            const int pageSize = 2;
             
            var selectedProperties = _halisahaService.GetSelectedProperties(halisahaId);
            var properties = _halisahaService.GetAllProperties();
            ViewBag.AvgPoint = _halisahaService.GetAvgPoint(halisahaId);

            ViewBag.Properties = properties;
             var rezervationListModel = new RezervationListModel()
            {
                PageInfo = new PageInfo()
                {
                    TotalItems = _halisahaService.GetCountComments(halisahaId),
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                   
                },
                SelectedProperties = selectedProperties.Select(i => i.Property.PropertyName)
                
            };
            
            DateTime date1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            var rezervations = _halisahaService.GetHalisahaRezervations(halisahaId);
            if (rezervations == null)
            {
                return View();
            }
            
         
            var comm =  _halisahaService.GetComments(halisahaId,page,pageSize);
            
            
            ViewBag.Comments = comm;

         


           

            ViewBag.Images = _halisahaService.GetHalisahaImages(halisahaId);
            var a = new DateHelper();
            var c = a.createDynamicTable(rezervations);
            ViewBag.Dates = a.getDateTime();
            ViewBag.Url = _halisahaService.GetHalisahaById(halisahaId);
            ViewBag.aa = c;

               


           
            return View(rezervationListModel);
        }
        [Authorize]
        public IActionResult Payment(string city, string slug, string date, string time)
        {
            Console.WriteLine(date + " " + time);


            return View();
        }
        [HttpPost]
        [Authorize]
        public IActionResult Payment(string city, int halisahaId, string slug, string date, string time)
        {
            Console.WriteLine(halisahaId);
            //_halisahaService.AddPreTransaction()

            var reservation = new Rezervation()
            {
                UserId = _userManager.GetUserId(User),
                Tarih = date,
                Saat = time,
                HalisahaId = halisahaId
            };
            _halisahaService.MakeReservation(reservation);
            return Redirect($"/halisaha/{city}/{halisahaId}/{slug}");
        }
        [Authorize]
        public IActionResult RegisterHalisaha()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> RegisterHalisaha(string message)
        {
            if (message == null)
            {
                return View();
            }
            var userId = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(userId);
            var userRole = await _userManager.IsInRoleAsync(user, "manager");
            if (userRole)
            {
                return View();
            }
            Message message1 = new Message()
            {
                UserId = userId,
                MessageContent = message
            };
            _halisahaService.AddMessage(message1);
            return View();
        }

    }
}