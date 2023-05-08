using Microsoft.EntityFrameworkCore;

namespace OneToManyWebAPI.Models
{
    public class MenuForAPIContext:DbContext
    {
        public DbSet<MenuForAPI> MenuFors { get; set; }
        public DbSet<MenuTypeAPI> MenuTypes { get; set; }
        public DbSet<UserInfo> userInfos { get; set; }

        public MenuForAPIContext(DbContextOptions<MenuForAPIContext>options):base(options)
        {
            
        }
    }
}
