using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace LINQ_to_SQL_28_04
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext dt=new DataClasses1DataContext();
            GridView1.DataSource = dt.Clg_Depts.ToList();
            GridView1.DataBind();
        }

        protected void Fnd_Click(object sender, EventArgs e)
        {
            using(DataClasses1DataContext dt=new DataClasses1DataContext())
            {
                int id = Convert.ToInt32(DropDownList1.SelectedValue);
                Clg_Dept cd = dt.Clg_Depts.FirstOrDefault(x => x.Rollno == id);
                TextArea1.InnerText = $"{cd.Rollno} {cd.Stdname} {cd.Department.Deptname}";
            }
        }
    }
}