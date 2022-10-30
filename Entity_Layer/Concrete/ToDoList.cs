using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class ToDoList
    {
        [Key]
        public int jobID { get; set; }
        public string jobContent{ get; set; }
        public bool jobStatus{ get; set; }
    }
}
