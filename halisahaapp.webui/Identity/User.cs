using Microsoft.AspNetCore.Identity;

namespace halisahaapp.webui.Identity
{
    public class User:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImgUrl { get; set; }
    }
}