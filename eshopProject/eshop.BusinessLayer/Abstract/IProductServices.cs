﻿using eshop.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.BusinessLayer.Abstract
{
    public interface IProductServices
    {
        List<Product>  GetProductList();

        Product GetProductById(int productId);

        List<Product> SearchList(String searchText, String categoryName);


        #region Admin
        int productCount();
        Product productDetails(int id);
        int productUpdate();
        int productDelete(int id);
        int productCreate(Product product);
#endregion
    }
}
