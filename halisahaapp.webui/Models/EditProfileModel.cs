using System.ComponentModel.DataAnnotations;

namespace halisahaapp.webui.Models
{
    public class EditProfileModel
    {
        
        public string Email { get; set; }
       
        public string NickName { get; set; }
        [Required(ErrorMessage ="İsim boş bırakılamaz.")]
         [StringLength(30, MinimumLength = 3, ErrorMessage = "İsminiz 3-30 karakter aralığında olmalıdır.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Soyisim boş bırakılamaz.")]
         [StringLength(30, MinimumLength = 3, ErrorMessage = "Soyisminiz 3-30 karakter aralığında olmalıdır.")]
        public string LastName { get; set; }
        public string ImgUrl { get; set; }
    }
}