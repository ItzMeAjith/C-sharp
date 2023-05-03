using System.ComponentModel.DataAnnotations;

namespace WEB_API.Models
{
    public class API_Menu
    {
        [Key]
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
        public int ItemCount { get; set; }
    }
}
