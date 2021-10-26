using System.Collections.Generic;

namespace halisahaapp.entity
{
    public class Halisaha
    {
        public int Id { get; set; } 
        // public int UserId { get; set; }
        // public User User { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Content { get; set; }
        public string Openning { get; set; }
        public string Closing { get; set; }
        public int Price { get; set; }
        public string Slug { get; set; }
        public double AvgPoint { get; set; }
        public List<HalisahaProperty> HalisahaProperties { get; set; }
        public List<Image> Images { get; set; }
        public List<Rezervation> Rezervations { get; set; }
        public List<Comment> Comments {get;set;}

    }
}