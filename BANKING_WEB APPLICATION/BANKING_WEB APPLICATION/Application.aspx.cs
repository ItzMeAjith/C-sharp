using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BANKING_WEB_APPLICATION
{
    public partial class Application : System.Web.UI.Page
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=BANKING_SYSTEM;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from accountant_details", con);
            SqlDataReader dr= cmd.ExecuteReader();
            gri1.DataSource = dr;
            gri1.DataBind();
            con.Close();

        }

        protected void Sub_Click(object sender, EventArgs e)
        {
            string userid = UserID.Text;
            string name = name12.Text;
            DateTime dob=Convert.ToDateTime(DOB.Text).ToString;
            string phone = phone12.Text;
            string mail=mail12.Text;
            string add = address12.Text;
            string pi = pic.FileName;

            SqlConnection con=new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=BANKING_SYSTEM;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
            con.Open();
            string si = $"insert into accountant_details(name,birthdate,phoneno,mailid,address,photo) values('{name}','{dob}','{phone}','{mail}','{add}','{pi}')";
            SqlCommand cmd = new SqlCommand(si, con);
            cmd.ExecuteNonQuery();
           // GridView1.DataSource =
            Response.Write("Success");
            con.Close();

        }
    }
}