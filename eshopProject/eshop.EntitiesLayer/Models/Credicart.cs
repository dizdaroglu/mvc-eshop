using eshop.CoreLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.EntitiesLayer.Models
{
    public class Credicart : BaseEntity, IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CredicartId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string cvc { get; set; }
        public DateTime lastdate { get; set; }
        public Guid cartNo { get; set; }

        public int CreditCartTypeId { get; set; }
        public virtual CreditCartType CreditCartType { get; set; }
    }
}
