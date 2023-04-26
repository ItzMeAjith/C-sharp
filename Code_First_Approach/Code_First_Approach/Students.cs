using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Approach
{
    internal class Students
    {
        [Key]
        public int rollno { get; set; }
        public string name { get; set; }
        public string dept { get; set; }
        public double cgpa { get; set; }
    }
}
