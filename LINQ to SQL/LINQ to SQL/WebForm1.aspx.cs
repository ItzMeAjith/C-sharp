using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ_to_SQL
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();
            GridView1.DataSource= data.colleges.Where(x=>x.DeptId==2).ToList();
            GridView1.DataBind();
            GridView2.DataSource= data.Departments.ToList();
            GridView2.DataBind();
        }

        protected void Unnamed1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}