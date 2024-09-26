using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class Testimonial
    {
        public int TestimonialID { get; set; }
        public String Name { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public String Image { get; set; }
    }
}
