using System;
using System.Threading.Tasks;
using halisahaapp.webui.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace halisahaapp.webui.Controllers
{
    public class UserController : Controller
    {
        private UserManager<User> _userManager;
        public UserController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> UserProfile(string userName)
        {
            Console.WriteLine(userName);
            //profil image
            var a = await _userManager.FindByNameAsync(userName);
            if(a==null)
            {
                
                return NotFound();
            }
            
            return View(a);
        }


    }
}