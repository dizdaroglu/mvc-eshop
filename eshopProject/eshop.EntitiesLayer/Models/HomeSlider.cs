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
    public class HomeSlider:BaseEntity,IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int sliderId { get; set; }
        public string ImagePath { get; set; }
        public string sliderDescription { get; set; }
        public string sliderTitle { get; set; }
    }
}
