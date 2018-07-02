using eshop.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eshop.EntitiesLayer.Models;
using eshop.DataAccessLayer.IUnitOfWorkPattern.Concreate;
using eshop.DataAccessLayer.IUnitOfWorkPattern.Abstract;

namespace eshop.BusinessLayer.Concreate
{
    public class SubCategoryManager : ISubCategoryServices
    {
        private IUnitOfWork _uow;
        public SubCategoryManager()
        {
            _uow = new UnitofWork(new DataAccessLayer.DAL.DatabaseContext());
        }
        public List<SubCategory> getSubCategory()
        {
            return _uow.SubCategoryDal.FindAll();
        }

        public int subcategoryCreate(SubCategory subCategory)
        {
            _uow.SubCategoryDal.Add(subCategory);
            return _uow.Complete();
        }

        public int subcategoryDelete(int id)
        {
            SubCategory find = _uow.SubCategoryDal.Find(m => m.SubCategoryId == id);
            
            _uow.SubCategoryDal.Remove(find);
            
            return _uow.Complete();
        }

        public SubCategory subcategoryDetails(int id)
        {
            return _uow.SubCategoryDal.Find(m => m.SubCategoryId == id);
        }

        public int subcategoryUpdate()
        {
            return _uow.Complete();
        }
    }
}
