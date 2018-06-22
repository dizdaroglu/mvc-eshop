using eshop.CoreLayer.DataAccess.Concreate;
using eshop.DataAccessLayer.Abstract;
using eshop.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using eshop.DataAccessLayer.DAL;

namespace eshop.DataAccessLayer.Concreate
{
    public class EfImageFilesDal : GenericRepository<ImageFiles>, IImageFilesDal
    {
        public EfImageFilesDal(DatabaseContext context) : base(context)
        {
        }
    }
}
