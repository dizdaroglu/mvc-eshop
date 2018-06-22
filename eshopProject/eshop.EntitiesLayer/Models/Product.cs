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
    public class Product : BaseEntity, IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        public String Name { get; set; }
        public String Description { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int? Star { get; set; }


        // Burada ilişkiler var!

        // Marka
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }

        // Alt kategori
        public int SubCategroyId { get; set; }
        public virtual SubCategory SubCategory { get; set; }

        // Bir ürünün birden fazla commeti olur 
        // Bir ürünün birden fazla indirimi olur!
        // iBir ürünün birden fazla coloru olur !
        // Bir ürünün birden fazla imageFiels olur 
        // Bir ürün birden fazla kulanicicin basketine girebilir
        // Bir ürün birden fazla  fav edilebilir 
        // Bir ürünün birden fazla size olur 
        public virtual List<Comments> Comments { get; set; }
        public virtual List<Discount> Discounts { get; set; }
        public virtual List<Colors> Colors { get; set; }
        public virtual List<ImageFiles> ImageFiles { get; set; }
        public virtual List<Basket> Baskets { get; set; }

        public virtual List<Fav> Favs { get; set; }
        public virtual List<Size> Sizes { get; set; }
        public Product()
        {
            ImageFiles = new List<ImageFiles>();
            Comments = new List<Comments>();
            Discounts = new List<Discount>();
            Colors = new List<Colors>();
            Baskets = new List<Basket>();
            Favs = new List<Fav>();
            Sizes = new List<Size>();
        }
    }
}
