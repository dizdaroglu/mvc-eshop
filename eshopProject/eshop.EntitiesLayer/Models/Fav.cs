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
    public class Fav:BaseEntity,IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FavId { get; set; }

        // Bu favlanan ürün ne !
        public int productID { get; set; }
        public virtual Product Product { get; set; }

        // Favlayan kim!
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }


    }
}
