using System.ComponentModel.DataAnnotations;

namespace halisahaapp.webui.Models
{
    public class LoginModel
    {
        [DataType(DataType.EmailAddress, ErrorMessage = "Lütfen uygun email adresi giriniz")]
        [Required(ErrorMessage = "Email zorunlu bir alan.")]
        public string Email { get; set; }
         
        [Required(ErrorMessage ="Şifre zorunlu bir alan.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}