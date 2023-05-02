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
    public partial class Application_Form : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string user = A_usrID.Value;
            string nme=A_name.Value;
            string gen = F_gen.Value;
            string ph=A_phone.Value;
            string mai=A_mailid.Value;
            string dob=A_DOB.Value;
            string pi=A_pic.Value;
            string add=A_Addr.Value;
            try
            {
                con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=banking_system;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
                con.Open();
                cmd = new SqlCommand($"insert into accountant_details(UserID,Name,birthdate,phoneno,mailid,address,photo) values" +
                    $"('{user}','{nme}','{dob}','{ph}','{mai}','{add}','{pi}')", con);
                cmd.ExecuteNonQuery();
               // SqlCommand cmd1 = new SqlCommand($"insert into user_transaction values({accno},{bal})",con);
                MessageBox.Show("Account created successfully!!!!!");
                Response.Redirect("Bank_Home.aspx");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registered user only allowed to open account !!!");
            }
            finally { con.Close(); }
        }
    }
}