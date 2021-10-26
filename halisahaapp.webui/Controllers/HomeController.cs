using System.Collections.Generic;
using halisahaapp.webui.Helper;
using halisahaapp.webui.Models;
using Microsoft.AspNetCore.Mvc;

namespace halisahaapp.webui.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            // List<City> cities = new List<City>(){
            //     new City(){Name = "karaman", PlakaNo="70"},
            //     new City(){Name = "konya", PlakaNo="42"}
            // };
            // var ct = new City(){
            //     Name = "daf",
            //     PlakaNo= "33"
            // };
            var a = CityHelper.cities;
            

            return View(a);
        }
        public IActionResult List()
        {
            return View();
        }
    }
}