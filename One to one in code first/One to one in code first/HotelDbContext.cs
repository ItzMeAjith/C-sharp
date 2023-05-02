using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_to_one_in_code_first
{
    internal class HotelDbContext:DbContext
    {
        public DbSet<Menu> Menu { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }   

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-GL7RKG7\\SQLEXPRESS;database=NewCanteen_Management;integrated security=true;trustservercertificate=true;");
        }
    }
}
