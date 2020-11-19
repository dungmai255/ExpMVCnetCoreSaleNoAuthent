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
        public User User { get; set; }
        public Quyen Quyen { get; set; }
        public Category Category { get; set; }
        public Stock Stock { get; set; }
        public Store Store { get; set; }
        public Productor Productor { get; set; }
        public Product Product { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration["Connection"]);
        }
    }
   
}
