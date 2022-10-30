using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class WriterUser : IdentityUser<int>
    {
        public string writerUserName { get; set; }
        public string writerUserSurname { get; set; }
        public string writerUserImageUrl { get; set; }
    }
}
