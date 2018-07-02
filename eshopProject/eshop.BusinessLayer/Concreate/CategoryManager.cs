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
    public class CategoryManager : ICategoryServices
    {
        private IUnitOfWork unitOfWork;
        public CategoryManager()
        {
            unitOfWork = new UnitofWork(new DataAccessLayer.DAL.DatabaseContext());
        }

        public int categoryCreate(Category category)
        {
            unitOfWork.CategoryDal.Add(category);
            return unitOfWork.Complete();
        }

        public int categoryDelete(int id)
        {
            Category find = unitOfWork.CategoryDal.Find(m=>m.CategoryId == id);
           
            unitOfWork.CategoryDal.Remove(find);

            return unitOfWork.Complete();
        }

        public Category categoryDetails(int id)
        {
            return unitOfWork.CategoryDal.Find(m => m.CategoryId == id);
        }

        public int categoryUpdate()
        {
            return unitOfWork.Complete();
        }

        public List<Category> GetCategories()
        {
            return unitOfWork.CategoryDal.GetCategoriesList();
        }
    }
}
