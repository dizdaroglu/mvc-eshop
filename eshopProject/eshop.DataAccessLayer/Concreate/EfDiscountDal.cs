using eshop.CoreLayer.DataAccess.Concreate;
using eshop.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using eshop.DataAccessLayer.DAL;
using eshop.DataAccessLayer.Abstract;

namespace eshop.DataAccessLayer.Concreate
{
    public class EfDiscountDal : GenericRepository<Discount>, IDiscountDal
    {
        public EfDiscountDal(DatabaseContext context) : base(context)
        {
        }
    }
}
