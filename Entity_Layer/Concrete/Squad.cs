using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class Squad
    {
        [Key]
        public int memberID { get; set; }
        public string memberFullName { get; set; }
        public string memberTitle { get; set; }
        public string memberImageUrl { get; set; }
        public string projectProgress { get; set; }
    }
}
