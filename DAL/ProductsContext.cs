using ExpMVCnetCoreSaleNoAuthent.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpMVCnetCoreSaleNoAuthent.DAL
{
    public class ProductsContext : DbContext
    {
        private readonly IConfiguration Configuration;
        public ProductsContext()
        {

        }
        public ProductsContext(IConfiguration configuration) : base((DbContextOptions)configuration)
        {
            Configuration = configuration;
        }
        public DbSet<UserModel> User { get; set; }
        public DbSet<QuyenModel> Quyen { get; set; }
        public DbSet<CategoryModel> Category { get; set; }
        public DbSet<StockModel> Stock { get; set; }
        public DbSet<StoreModel> Store { get; set; }
        public DbSet<ProductorModel> Productor { get; set; }
        public DbSet<ProductModel> Product { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration["Connection"]);
        }
    }
   
}
