using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class Experience
    {
        [Key]
        public int experienceID { get; set; }
        public string experienceTitle { get; set; }
        public string experienceDate { get; set; }
        public string experienceImageUrl { get; set; }
        public string experienceDescription { get; set; }
    }
}
