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
    public class BillAddress:BaseEntity,IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BillAdressId { get; set; }
        public String Address { get; set; }

        public int CustomerId { get; set; }
        // Burada ilişki 
        public virtual Customer Customer { get; set; }
    }
}
