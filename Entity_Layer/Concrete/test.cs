﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class test
    {
        [Key]
        public int ID { get; set; }
        public string Name{ get; set; }
    }
}
