using System.ComponentModel.DataAnnotations;

namespace OneToManyWebAPI.Models
{
    public class MenuTypeAPI
    {
        [Key]
        public int? TypeID { get; set; }
        public string? TypeName { get; set; }

        //
        public ICollection<MenuForAPI>? Menus { get; set; }
    }
}
