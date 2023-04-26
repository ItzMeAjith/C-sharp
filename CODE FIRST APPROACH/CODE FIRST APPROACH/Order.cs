using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODE_FIRST_APPROACH
{
    internal class Order
    {
        [Key]
        public int OrderID { get; set; }
        public string ItemName { get; set; }
        public double AmountPaid { get; set; }
        public DateTime OrderTime { get; set; }
        public string DeliveryAddress { get; set; } 
        
    }
}
