using System.Collections.Generic;
using halisahaapp.entity;

namespace halisahaapp.webui.Models
{
    public class HalisahaModel
    {
        // public string UserId { get; set; }
        // public string Name { get; set; }
        // public string City { get; set; }
        // public string Content { get; set; }
        // public string Openning { get; set; }
        // public string Closing { get; set; }
        public int Price { get; set; }
        // public string Slug { get; set; }
        public List<Halisaha> Halisahas { get; set; }

    }
}