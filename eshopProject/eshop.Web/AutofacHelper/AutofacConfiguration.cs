using Autofac;
using Autofac.Integration.Mvc;
using eshop.BusinessLayer.Abstract;
using eshop.BusinessLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace eshop.Web.AutofacHelper
{
    public class AutofacConfiguration
    {
        /// <summary>
        /// Bu autofac ile config ayarlarımızı yapmaktadir.
        /// </summary>
        public static void Config()
        {
            // get the builder yaptım
            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            // cast işlemler 
            builder.RegisterType<CategoryManager>().As<ICategoryServices>();
            builder.RegisterType<ProductManager>().As<IProductServices>();
            builder.RegisterType<ColorManager>().As<IColorServices>();
            builder.RegisterType<SizeManager>().As<ISizeServices>();
            builder.RegisterType<BrandManager>().As<IBrandServices>();
            builder.RegisterType<CustomerManager>().As<ICustomerServices>();
            builder.RegisterType<FavManager>().As<IFavServices>();
            builder.RegisterType<BasketManager>().As<IBasketServices>();
            builder.RegisterType<CommentsManager>().As<ICommentServices>();
            builder.RegisterType<SubCategoryManager>().As<ISubCategoryServices>();
            IContainer container =  builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));


        }
    }
}