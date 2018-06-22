using eshop.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.DataAccessLayer.IUnitOfWorkPattern.Abstract
{
    public interface IUnitOfWork
    {

        
        int Complete();

        // Get the interfaces
        ICategoryDal CategoryDal { get; }
        IBasketDal BasketDal { get; }
        IBillAdressDal BillAdressDal { get; }
        IBrandDal BrandDal { get; }
        IColorsDal ColorsDal { get; }
        ICommentsDal CommentsDal { get; }
        ICredicartDal CredicartDal { get; }
        ICustomerDal CustomerDal { get; }
        IDiscountDal DiscountDal { get; }
        IFavDal FavDal { get; }
        IHomeSliderDal HomeSliderDal { get; }
        IProductDal ProductDal { get; }
        ISalesDal SalesDal { get; }
        ISizeDal SizeDal { get; }
        ISubCategoryDal SubCategoryDal { get; }
        IImageFilesDal ImageFilesDal { get; }


    }
}
