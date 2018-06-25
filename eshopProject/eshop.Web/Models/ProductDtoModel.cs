using eshop.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eshop.Web.Models
{
    public class ProductDtoModel
    {
        public List<Colors> productColors { get; set; }
        public List<Size>   productSize  { get; set; }
        public List<Brand>  productBrands { get; set; }


    }
}