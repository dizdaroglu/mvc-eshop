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
    public class Comments:BaseEntity,IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommentId { get; set; }

        public String Text { get; set; }
        public bool isActive{ get; set; }

        // Burada bir ilişki var!

        // Her yorum bir ürüne aittir.
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        // Csutoemr 
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        




    }
}
