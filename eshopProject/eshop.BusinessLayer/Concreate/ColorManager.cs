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
    public class ColorManager : IColorServices
    {
        private IUnitOfWork _unitOfWork;

        public ColorManager()
        {
            _unitOfWork = new UnitofWork(new DataAccessLayer.DAL.DatabaseContext());
        }

        public int colorCreate(Colors color)
        {
            _unitOfWork.ColorsDal.Add(color);
            return _unitOfWork.Complete();
        }

        public int colorDelete(int id)
        {
           Colors find = _unitOfWork.ColorsDal.Find(m => m.ColorsId == id);
          
            _unitOfWork.ColorsDal.Remove(find);
            return _unitOfWork.Complete();
        }

        public Colors colorDetails(int id)
        {
            return _unitOfWork.ColorsDal.Find(m =>m.ColorsId == id);
        }

        public int colorUpdate()
        {
            return _unitOfWork.Complete();
        }

        public List<Colors> GetColors()
        {
            return _unitOfWork.ColorsDal.FindAll();
        }
    }
}
