
using eshop.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.DataAccessLayer.DAL
{
   public class DatabaseContext:DbContext
    {

        public DatabaseContext():base("connStr")
        {

        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Basket> Basket { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Colors> Colors { get; set; }
        public DbSet<Credicart> Credicart { get; set; }
        public DbSet<Fav> Fav { get; set; }
        public DbSet<HomeSlider> HomeSlider { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<BillAddress> BillAddress { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<CreditCartType> CreditCartType { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Discount> Discount { get; set; }
        public DbSet<Size> Size { get; set; }
        public DbSet<ImageFiles> ImageFiles { get; set; }
        public DbSet<SubCategory> SubCategory { get; set; }
        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
