using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class Feature
    {
        [Key]
        public int featureID { get; set; }
        public string featureHeader { get; set; }
        public string featureName { get; set; }
        public string featureTitle { get; set; }
    }
}
