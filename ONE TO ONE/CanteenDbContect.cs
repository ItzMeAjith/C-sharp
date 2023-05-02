using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONE_TO_ONE
{
    internal class CanteenDbContect:DbContext
    {
        public DbSet<Total_Menu> TMenus { get; set; }
        public DbSet<VEG>vEGs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-GL7RKG7\\SQLEXPRESS;database=Canteen_Management;integrated security=true;trustservercertificate=true;");
        }

    }
}
