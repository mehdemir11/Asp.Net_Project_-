using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class SocialMedia
    {
        [Key]
        public int socialMediaID { get; set; }
        public string socialMediaTitle { get; set; }
        public string socialMediaUrl { get; set; }
        public string socialMediaIcon { get; set; }
        public string socialMediaIcon1 { get; set; }
        public bool status { get; set; }
    }
}
