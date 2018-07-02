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
    public class ProductManager : IProductServices
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

        public int productCount()
        {
            return _unitOfWork.ProductDal.FindAll().Count();
        }

        public int productCreate(Product product)
        {
            _unitOfWork.ProductDal.Add(product);
            return _unitOfWork.Complete();
        }

        public int productDelete(int id)
        {
            Product find = _unitOfWork.ProductDal.Find(m => m.ProductId == id);

#region ilişkilerin silinmesi
            foreach (var item in find.Baskets)
            {
                _unitOfWork.BasketDal.Remove(item);
            }
            foreach (var item in find.Colors)
            {
                _unitOfWork.ColorsDal.Remove(item);
            }
            foreach (var item in find.Comments)
            {
                _unitOfWork.CommentsDal.Remove(item);
            }
            foreach (var item in find.Discounts)
            {
                _unitOfWork.DiscountDal.Remove(item);
            }
            foreach (var item in find.ImageFiles)
            {
                _unitOfWork.ImageFilesDal.Remove(item);
            }
            foreach (var item in find.Sizes)
            {
                _unitOfWork.SizeDal.Remove(item);
            }
#endregion

            _unitOfWork.ProductDal.Remove(find);
            return _unitOfWork.Complete();
        }

        public Product productDetails(int id)
        {
            return _unitOfWork.ProductDal.Find(m => m.ProductId == id);
        }

        public int productUpdate()
        {
            return _unitOfWork.Complete();
        }

        public List<Product> SearchList(string searchText, string categoryName)
        {
            if ((String.IsNullOrEmpty(searchText) || searchText == "") && (String.IsNullOrEmpty(categoryName) || categoryName == ""))
            {
                return _unitOfWork.ProductDal.FindAll();
            }
            return _unitOfWork.ProductDal.FindAll(m => m.SubCategory.Category.Name.Contains(categoryName) && m.Name.Contains(searchText));
        }

    }
}
