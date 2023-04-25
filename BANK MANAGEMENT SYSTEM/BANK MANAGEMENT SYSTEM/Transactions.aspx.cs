using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BANK_MANAGEMENT_SYSTEM
{
    public partial class Transactions : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=banking_system;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
            con.Open();
            //
            cmd = new SqlCommand($"select * from transaction_log", con);
            SqlCommand cm= new SqlCommand($"select * from accountant_details", con);
            dr = cmd.ExecuteReader();
            DataTable dt= new DataTable();
            dt.Load(dr);
            GridView1.DataSource = dt;
            GridView1.DataBind();

            //
            dr = cm.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Load(dr);
            GridView2.DataSource = dt1;
            GridView2.DataBind();
            con.Close();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void cnt_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=banking_system;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
            con.Open();

            cmd = new SqlCommand($"sp_count1", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@cnt", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int count = (int)cmd.Parameters["@cnt"].Value;
            MessageBox.Show($"We have {count} customers in our bank!!!");
        }
    }
}