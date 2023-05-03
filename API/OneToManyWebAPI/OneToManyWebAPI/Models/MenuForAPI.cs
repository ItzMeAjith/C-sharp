using System.ComponentModel.DataAnnotations;

namespace OneToManyWebAPI.Models
{
    public class MenuForAPI
    {
        [Key]
        public int? ItemID { get; set; }
        public string? ItemName { get; set; }
    //    public int TypeID { get; set; }
        public int? ItemPrice {get;set;}
        public int? ItemCount { get; set;}
        
        //Navigation
        public MenuTypeAPI? Mtype { get; set; }
    }
}
