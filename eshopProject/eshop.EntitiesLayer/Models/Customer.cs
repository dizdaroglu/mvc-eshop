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
    public class Customer:BaseEntity,IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }

        
        public String Name { get; set; }
        public String Surname { get; set; }

        [Required(ErrorMessage ="Lütfen bu alanı boş bırakmayınız.")]
        public String Email { get; set; }

        [Required(ErrorMessage ="Lütfen bu  alanı boş bırakmayınız.")]
        public String UserName { get; set; }

        [Required(ErrorMessage = "Lütfen bu  alanı boş bırakmayınız.")]
        public String Password { get; set; }
        public String ProfileImage { get; set; }

        // Burada bir ilişki var!
        // bir kullanicinin birden fazla favı olur 
        // Bir kulanicinin birden fazla basketi olur 
        // Bir kulanicimim satşları olur
        // Bir kulanicinin birden fazla  commenti olur 
        // bir kullaniicinin virden fazla   fatura adresi olur 
        public virtual List<Fav> Favs { get; set; }
        public virtual List<Basket>  Baskets { get; set; }
        public virtual List<Sales> Sales { get; set; }
        public virtual List<Comments> Comments { get; set; }

        public virtual List<BillAddress> BillAddresses { get; set; }

        public Customer()
        {
            Comments = new List<Comments>();
            Baskets = new List<Basket>();
            Favs = new List<Fav>();
            BillAddresses = new List<BillAddress>();
            Sales = new List<Sales>();
        }
    }
}
