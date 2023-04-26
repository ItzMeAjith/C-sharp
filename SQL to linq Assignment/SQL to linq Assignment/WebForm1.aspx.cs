using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SQL_to_linq_Assignment
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext dt = new DataClasses1DataContext();
            Gridview1.DataSource = dt.Clg_Depts.ToList();
            Gridview1.DataBind();

        }
        protected void insert_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext dt = new DataClasses1DataContext())
            {
                Clg_Dept clg = new Clg_Dept()
                {
                    Rollno = (byte)Convert.ToInt32(roll.Text),
                    Stdname = name.Text,
                    DeptID = Convert.ToInt32(select.SelectedItem.Value)
                };
                dt.Clg_Depts.InsertOnSubmit(clg);
                dt.SubmitChanges();
                // MessageBox.Show("Inserted successfully");
            }


        }
    }
}