using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class Message
    {
        [Key]
        public int messageID { get; set; }
        public string messageTitle { get; set; }
        public string messageMail { get; set; }
        public string messageContent { get; set; }
        public DateTime Date { get; set; }
        public bool status { get; set; }
    }
}
