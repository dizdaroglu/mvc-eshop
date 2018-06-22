using eshop.CoreLayer.DataAccess.Concreate;
using eshop.DataAccessLayer.Abstract;
using eshop.DataAccessLayer.DAL;
using eshop.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.DataAccessLayer.Concreate
{
    public class EfCategoryDal:GenericRepository<Category>,ICategoryDal
    {
        // private DatabaseContext GetContext { get { return _context as DatabaseContext; } }

        public EfCategoryDal(DatabaseContext context):base(context)
        {

        }
    }
}
