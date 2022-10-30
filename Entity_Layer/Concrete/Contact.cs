using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class Contact
    {
        [Key]
        public int contactID { get; set; }
        public string contactTitle { get; set; }
        public string contactDescription { get; set; }
        public string contactMail { get; set; }
        public string contactPhone { get; set; }
    }
}
