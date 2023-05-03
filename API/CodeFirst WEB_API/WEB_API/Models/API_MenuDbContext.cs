using Microsoft.EntityFrameworkCore;

namespace WEB_API.Models
{
    public class API_MenuDbContext:DbContext
    {
        public DbSet<API_Menu> Menus { get; set; }
        public API_MenuDbContext(DbContextOptions<API_MenuDbContext> options):base(options)
        {
            
        }
    }
}
