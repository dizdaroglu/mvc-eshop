using eshop.DataAccessLayer.Abstract;
using eshop.DataAccessLayer.Concreate;
using eshop.DataAccessLayer.DAL;
using eshop.DataAccessLayer.IUnitOfWorkPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.DataAccessLayer.IUnitOfWorkPattern.Concreate
{
    public class UnitofWork:IUnitOfWork
    {
        private DatabaseContext _context; 

        public UnitofWork(DatabaseContext context)
        {
            _context = context;
            CategoryDal = new EfCategoryDal(_context);
            BasketDal = new EfBasketDal(_context);
            BillAdressDal = new EfBillAdressDal(_context);
            BrandDal = new EfBrandDal(_context);
            ColorsDal = new EfColorsDal(_context);
            CommentsDal = new EfCommentsDal(_context);
            CredicartDal = new EfCredicartDal(_context);
            CustomerDal = new EfCustomerDal(_context);
            DiscountDal = new EfDiscountDal(_context);
            FavDal = new EfFavDal(_context);
            HomeSliderDal = new EfHomeSliderDal(_context);
            ImageFilesDal = new EfImageFilesDal(_context);
            ProductDal = new EfProductDal(_context);
            SalesDal = new EfSalesDal(_context);
            SizeDal = new EfSizeDal(_context);
            SubCategoryDal= new EfSubCategoryDal(_context);

        }

        public ICategoryDal CategoryDal { get; private set; }

        public IBasketDal BasketDal { get; private set; }

        public IBillAdressDal BillAdressDal { get; private set; }

        public IBrandDal BrandDal { get; private set; }

        public IColorsDal ColorsDal { get; private set; }

        public ICommentsDal CommentsDal { get; private set; }

        public ICredicartDal CredicartDal { get; private set; }

        public ICustomerDal CustomerDal { get; private set; }

        public IDiscountDal DiscountDal { get; private set; }

        public IFavDal FavDal { get; private set; }

        public IHomeSliderDal HomeSliderDal { get; private set; }

        public IProductDal ProductDal { get; private set; }

        public ISalesDal SalesDal { get; private set; }
        public ISizeDal SizeDal { get; private set; }

        public ISubCategoryDal SubCategoryDal { get; private set; }

        public IImageFilesDal ImageFilesDal { get; private set; }

        /// <summary>
        /// UOW 'un temel prensibinini değişiklikleri  buraya kaydetmesidir.
        /// </summary>
        /// <returns></returns>
        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}
