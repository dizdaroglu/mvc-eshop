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
    public class Brand: BaseEntity, IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string BrandIcon { get; set; }


        // Bir markanin  birden fazla ürünü vardir.
        public virtual List<Product> Products  { get; set; }

        public Brand()
        {
            Products = new List<Product>();
        }

    }
}
