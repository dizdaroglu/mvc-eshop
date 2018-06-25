using eshop.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eshop.EntitiesLayer.Models;
using eshop.DataAccessLayer.IUnitOfWorkPattern.Abstract;
using eshop.DataAccessLayer.IUnitOfWorkPattern.Concreate;

namespace eshop.BusinessLayer.Concreate
{
    public class HomeSliderManager : IHomeSliderServices
    {
        private IUnitOfWork unitOfWork;
        public HomeSliderManager()
        {
            unitOfWork = new UnitofWork(new DataAccessLayer.DAL.DatabaseContext());
        }
        public void AddToHomeSlider(HomeSlider homeSlider)
        {
           // db eklenecek
        }
    }
}
