using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EntitFrame.Models
{
    internal class ProdContext : DbContext
    {
        private const string connectionstring = "Server=(localdb)\\mssqllocaldb;Database=ProdCore;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionstring);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductBatch> ProductBatch { get; set; }

        public DbSet<student> students { get; set; }
        public DbSet<Standard> standards { get; set; }

    }
}


