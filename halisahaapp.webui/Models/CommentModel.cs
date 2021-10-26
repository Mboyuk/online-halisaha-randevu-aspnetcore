using System.ComponentModel.DataAnnotations;

namespace halisahaapp.webui.Models
{
    public class CommentModel
    {
        [Required(ErrorMessage ="Puan şeçiniz.")]
        public double Point { get; set; }
        public string UserId { get; set; }
        public int HalisahaId { get; set; }
        [Required(ErrorMessage ="Lütfen yorum giriniz.")]
        
        public string Comment { get; set; }
    }
}