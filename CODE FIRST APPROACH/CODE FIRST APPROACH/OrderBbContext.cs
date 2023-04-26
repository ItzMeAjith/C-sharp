using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODE_FIRST_APPROACH
{
    internal class OrderBbContext:DbContext
    {
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-GL7RKG7\\SQLEXPRESS;database=Canteen_Management;integrated security=true;trustservercertificate=true;"); 
        }
    }
}
