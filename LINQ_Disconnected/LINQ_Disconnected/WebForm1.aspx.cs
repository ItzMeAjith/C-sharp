using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace LINQ_Disconnected
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e)
        {

            con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS;database=CIET;Integrated security=SSPI");
            con.Open();
            cmd = new SqlCommand("SELECT * FROM Students",con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Load(dr);
            GridView1.DataSource = tbl;
            GridView1.DataBind();
            con.Close();
        }

        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            string dep = dept.Text;
            con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS;database=CIET;Integrated security=SSPI");
            con.Open();
            cmd = new SqlCommand($"SELECT * FROM Students WHERE Dept='{dep}'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Load(dr);
            GridView2.DataSource = tbl;
            GridView2.DataBind();
            con.Close();
        }
    }
}