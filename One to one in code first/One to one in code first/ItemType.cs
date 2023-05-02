using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_to_one_in_code_first
{
    internal class ItemType
    {
        [Key]
        public int TypeID { get; set; }
        public string TypeName { get; set; }

        public Menu Menus { get; set; }
    }
}
