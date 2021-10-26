namespace halisahaapp.entity
{
    public class Rezervation
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Tarih { get; set; }
        public string Saat { get; set; }
        
        public int HalisahaId { get; set; }
        public Halisaha Halisaha { get; set; }
    }
}