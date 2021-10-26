using System.Collections.Generic;

namespace halisahaapp.entity
{
    public class Property
    {
        public int Id { get; set; }
        public string PropertyName { get; set; }
        public List<HalisahaProperty> HalisahaProperties { get; set; }

    }
}