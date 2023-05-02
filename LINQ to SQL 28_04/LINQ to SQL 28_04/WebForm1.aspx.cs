using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ_to_SQL_28_04
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext dt=new DataClasses1DataContext();
            GridView1.DataSource = dt.Voters.ToList();
            GridView1.DataBind();
        }
    }
}