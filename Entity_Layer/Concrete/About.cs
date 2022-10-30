using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class About
    {
        [Key]
        public int aboutID { get; set; }
        public string aboutTitle { get; set; }
        public string aboutDescription { get; set; }
        public string aboutAge { get; set; }
        public string aboutMail { get; set; }
        public string aboutPhone { get; set; }
        public string aboutAddress { get; set; }
        public string aboutImageUrl { get; set; }
    }
}
