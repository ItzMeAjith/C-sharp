using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ_to_SQL_Project
{
    public partial class Students_Attendance : System.Web.UI.Page
    {
        public object MessageBox { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext dt = new DataClasses1DataContext();
            Gridview1.DataSource = dt.Clg_Depts.ToList();
            Gridview1.DataBind();
        }

        protected void insert_Click(object sender, EventArgs e)
        {
            using(DataClasses1DataContext dt = new DataClasses1DataContext())
            {
                Clg_Dept clg = new Clg_Dept()
                {
                    Rollno = (byte)Convert.ToInt64(roll.Text),
                    Stdname = name.Text,
                    DeptID = Convert.ToInt32(selectdept.SelectedItem.Value)
                };
                dt.Clg_Depts.InsertOnSubmit(clg);
                dt.SubmitChanges();
               // MessageBox.Show("Inserted successfully");
            }
        }
    }
}