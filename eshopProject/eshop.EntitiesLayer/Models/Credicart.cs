using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.EntitiesLayer.Models
{
   public class Credicart
    {
        public int CredicartId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string cvc { get; set; }
        public DateTime lastdate { get; set; }
        public Guid cartNo { get; set; }
    }
}
