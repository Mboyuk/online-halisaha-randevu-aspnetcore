namespace halisahaapp.entity
{
    public class Image
    {
        public int Id { get; set; }
        public int HalisahaId { get; set; }
        public string ImageUrl { get; set; }
        public Halisaha Halisaha { get; set; }

    }
}