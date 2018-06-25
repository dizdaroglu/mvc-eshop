using eshop.BusinessLayer.Abstract;
using eshop.DataAccessLayer.IUnitOfWorkPattern.Abstract;
using eshop.DataAccessLayer.IUnitOfWorkPattern.Concreate;
using eshop.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.BusinessLayer.Concreate
{
    public class ProductManager:IProductServices
    {
        private IUnitOfWork _unitOfWork;
        public ProductManager()
        {
            _unitOfWork = new UnitofWork(new DataAccessLayer.DAL.DatabaseContext());
        }

        public Product GetProductById(int productId)
        {
            return _unitOfWork.ProductDal.Find(m => m.ProductId == productId);
        }

        public List<Product> GetProductList()
        {

            return _unitOfWork.ProductDal.FindAll();
        }

       
    }
}
