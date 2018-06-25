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
    public class Colors:BaseEntity,IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ColorsId { get; set; }
        [StringLength(10)]
        public String Code { get; set; }
        public string Name { get; set; }

        // Bu caolor hangş ürnüns
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
