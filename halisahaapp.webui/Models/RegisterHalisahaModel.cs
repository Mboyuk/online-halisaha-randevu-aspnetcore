using System.ComponentModel.DataAnnotations;

namespace halisahaapp.webui.Models
{
    public class RegisterHalisahaModel
    {
        // public int Id { get; set; }
        public string UserId { get; set; }
        [Required(ErrorMessage = "İsim zorunlu bir alan.")]

        [StringLength(50, MinimumLength = 5, ErrorMessage = "Description 5-50 karakter aralığında olmalıdır.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Şehir zorunlu bir alan.")]
        public string City { get; set; }
        [Required(ErrorMessage = "İçerik zorunlu bir alan.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Description 5-100 karakter aralığında olmalıdır.")]
        public string Content { get; set; }
        public string Openning { get; set; }
        public string Closing { get; set; }
        [Required(ErrorMessage = "Fiyat zorunlu bir alan.")]
        public int Price { get; set; }
    }
}