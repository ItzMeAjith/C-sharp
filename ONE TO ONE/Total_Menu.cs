using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONE_TO_ONE
{
    internal class Total_Menu
    {
        [Key]
        public int ItemID { get; set; }
        public string ItemName { get; set; }
      //  public int TypeID { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public ICollection<VEG> Veg { get; set; }
    }
}
