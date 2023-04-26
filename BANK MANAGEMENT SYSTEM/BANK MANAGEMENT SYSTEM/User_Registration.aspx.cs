using Antlr.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BANK_MANAGEMENT_SYSTEM
{
    public partial class User_Registration : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string name = usrID.Value;
            string mail = mailid.Value;
            string pass=psword.Value;
            con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=banking_system;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
            con.Open();
            cmd = new SqlCommand($"insert into USER_REGISTRATION values" +
                $"('{name}','{mail}','{pass}')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Registered successfully");
            Response.Redirect("Login.aspx");
        }
    }
}