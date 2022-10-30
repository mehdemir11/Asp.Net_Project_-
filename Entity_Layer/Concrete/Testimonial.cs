using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class Testimonial
    {
        [Key]
        public int testimonialID { get; set; }
        public string testimonialClientName { get; set; }
        public string testimonialCompany { get; set; }
        public string testimonialComment { get; set; }
        public string testimonialImageUrl { get; set; }
        public string testimonialTask { get; set; }

    }
}
