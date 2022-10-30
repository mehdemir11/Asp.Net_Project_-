using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class Service
    {
        [Key]
        public int serviceID { get; set; }
        public string serviceTitle { get; set; }
        public string serviceImageUrl { get; set; }
    }
}
