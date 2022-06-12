using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Jakub_Wawrzeniuk_DPS_Software_recruitment.Entities
{
    internal class OrdermanagementDbContext : DbContext
    {
        private string _connectionString = "Server=DESKTOP-FGSDN55\\RECRUITMENTJW;Database=OrderManagementSystemDb;Trusted_Connection=True;";
        public DbSet<Product>? Products { get; set; }
        public DbSet<Order>? Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(p => p.ProductName).IsRequired();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

    }
}
