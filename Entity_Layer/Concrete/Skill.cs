using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class Skill
    {
        [Key]
        public int skillID { get; set; }
        public string skillTitle { get; set; }
        public string skillValue { get; set; }
    }
}
