using Autofac;
using Autofac.Integration.Mvc;
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
            // get the builder 
            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            // cast işlemler 
            //builder.RegisterType<>

            IContainer container =  builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));


        }
    }
}