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
    public class Discount:BaseEntity,IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DiscountId { get; set; }

        public String Title { get; set; }
        public int DiscountRate { get; set; }
        public DateTime? ExpireDate { get; set; }

        // Burada bir ilişki var!

        // Discount hangi  ürüne 
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        

    }
}
