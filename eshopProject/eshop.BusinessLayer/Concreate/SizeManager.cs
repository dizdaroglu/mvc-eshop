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
    public class SizeManager : ISizeServices
    {
        private IUnitOfWork _unitOfWork;
        public SizeManager()
        {
            _unitOfWork = new UnitofWork(new DataAccessLayer.DAL.DatabaseContext());
        }

        public List<Size> GetSizeList()
        {
            return _unitOfWork.SizeDal.FindAll();
        }

        public int sizeCreate(Size size)
        {
            _unitOfWork.SizeDal.Add(size);
           return _unitOfWork.Complete();
        }

        public int sizeDelete(int id)
        {
            Size find = _unitOfWork.SizeDal.Find(m => m.SizeId == id);
           
            _unitOfWork.SizeDal.Remove(find);

            return _unitOfWork.Complete();
        }

        public Size sizeDetails(int id)
        {
            return _unitOfWork.SizeDal.Find(m => m.SizeId == id);
        }

        public int sizeUpdate()
        {
            return _unitOfWork.Complete();
        }
    }
}
