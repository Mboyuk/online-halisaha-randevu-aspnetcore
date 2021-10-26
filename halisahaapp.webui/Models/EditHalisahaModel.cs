using System.Collections.Generic;

namespace halisahaapp.webui.Models
{
    public class EditHalisahaModel
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Content { get; set; }
        public string Openning { get; set; }
        public string Closing { get; set; }
        public int Price { get; set; }
        public IEnumerable<string> SelectedProperties{ get; set; }
    }
}