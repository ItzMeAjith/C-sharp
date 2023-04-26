using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ_TO_SQL_FINAL
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();
            GridView1.DataSource = data.MENUs.ToList();
            GridView1.DataBind();
        }
    }
}