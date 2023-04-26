using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BANK_MANAGEMENT_SYSTEM
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string id = L_usrID.Value;
            string pa=L_psword.Value;
            con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=banking_system;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
            con.Open();
            
            cmd = new SqlCommand($"sp_Login",con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dep", id);
            cmd.Parameters.Add("@cnt", SqlDbType.VarChar,50).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            string count = (string)cmd.Parameters["@cnt"].Value;
            if (count == pa)
            {
                MessageBox.Show("successfully Logined");
                Response.Redirect("Bank_Home.aspx");
            }

            else
                MessageBox.Show("Wrong UserID or Password");

            con.Close();
        }
    }
}