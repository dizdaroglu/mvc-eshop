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
    public class Size:BaseEntity,IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SizeId { get; set; }

        public String SizeName { get; set; }

        // Burada bir ilişki var!
        // Bu size hangi ürünün 
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

    }
}
