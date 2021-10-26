using System;

namespace halisahaapp.entity
{
    public class PreTransaction
    {
        public int Id { get; set; } 
        public string UserId { get; set; }
        public int HalisahaId { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string HalisahaName { get; set; }
        public DateTime CreateAt { get; set; }
    }
}