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
    public class BrandManager : IBrandServices
    {
        private IUnitOfWork _uow;
        public BrandManager()
        {
            _uow = new UnitofWork(new DataAccessLayer.DAL.DatabaseContext());
        }

        public int brandCreate(Brand brand)
        {
            _uow.BrandDal.Add(brand);
            return _uow.Complete();
        }

        public int brandDelete(int id)
        {
            Brand find = _uow.BrandDal.Find(m => m.BrandId == id);
            
           
            _uow.BrandDal.Remove(find);

            return _uow.Complete();
        }

        public Brand brandDetails(int id)
        {
            return _uow.BrandDal.Find(m => m.BrandId == id);
        }

        public int brandUpdate()
        {
            return _uow.Complete();
        }

        public List<Brand> GetBrands()
        {
            return _uow.BrandDal.FindAll();
            
        }
    }
}
