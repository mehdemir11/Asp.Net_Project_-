using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class Portfolio
    {
        [Key]
        public int portfolioID { get; set; }
        public string portfolioTitle { get; set; }
        public string portfolioImageUrl { get; set; }
        public string projectUrl { get; set; }
        public string portfolioImageUrl2 { get; set; }
        public string portfolioPlatform { get; set; }
        public string portfolioPrice { get; set; }
        public bool portfolioStatus { get; set; }
        public string portfolioImage1 { get; set; }
        public string portfolioImage2 { get; set; }
        public string portfolioImage3 { get; set; }
        public string portfolioImage4 { get; set; }
        public int portfolioValue { get; set; }
    }
}
