using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using VendingMachinePro.Models;

namespace VendingMachinePro.Logic.Data
{
    internal class DBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "Server=DARKSKY\\SQLSERVER2022;Database=VendingMachineDB;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
