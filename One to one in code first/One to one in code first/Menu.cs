using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_to_one_in_code_first
{
    internal class Menu
    {
        [Key]
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        //  public int TypeID { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public ICollection<ItemType> itemTypes { get; set; }
    }
}
