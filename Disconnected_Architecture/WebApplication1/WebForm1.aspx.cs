using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void ctl02_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=local;database=CIET;Integrated security=SSPI");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Students", con);
            con.Open();
            SqlDataReader rd=cmd.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(rd);
            GridView1.DataSource = tb;
            GridView1.DataBind();
            con.Close();
        }
    }
}