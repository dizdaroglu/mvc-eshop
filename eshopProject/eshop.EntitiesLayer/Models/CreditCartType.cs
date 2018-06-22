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
    public class CreditCartType:BaseEntity,IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CreditCartTypeId { get; set; }

        public String CartName { get; set; }

        // komntrolet 
        // Bir kredi karti tipnini birden fazla kart iolur 
        public virtual List<Credicart> Credicarts { get; set; }

        public CreditCartType()
        {
            Credicarts = new List<Credicart>();
        }
    }
}
