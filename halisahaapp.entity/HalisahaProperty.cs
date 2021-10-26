namespace halisahaapp.entity
{
    public class HalisahaProperty
    {
        public int Id { get; set; }
        public int HalisahaId { get; set; }
        public Halisaha Halisaha { get; set; }
        public int PropertyId { get; set; }
        public Property Property { get; set; }
    }
}