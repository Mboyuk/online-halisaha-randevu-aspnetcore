using System.ComponentModel.DataAnnotations;

namespace halisahaapp.webui.Models
{
    public class EditAccountModel
    {
         [DataType(DataType.EmailAddress)]
       
        public string Email { get; set; }
         [DataType(DataType.Password)]
           [Required(ErrorMessage ="Lütfen mevcut şifrenizi giriniz")]
        public string CurrentPassword { get; set; }
         [DataType(DataType.Password)]
           [Required(ErrorMessage ="Lütfen Yeni şifrenizi giriniz")]
        public string NewPassword { get; set; }

         [DataType(DataType.Password)]
        [Compare("NewPassword",ErrorMessage ="Şifreler eşleşmiyor")]
        public string ReNewPassword { get; set; }
    }
}