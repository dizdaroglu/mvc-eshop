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
    public class SubCategory:BaseEntity,IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubCategoryId { get; set; }
        public String SubCategoryName { get; set; }
        public String SubCategoryDescription { get; set; }

        // burada bir ilişki category!

        // Bir alt kategori bir  kategoriye aittir.
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        // Bir alt kategorinin birden fazla ürünü olur 
        public virtual List<Product> Products { get; set; }

        public SubCategory()
        {
            Products = new List<Product>();
        }
    }
}
