using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace BANK_MANAGEMENT_SYSTEM
{
    public partial class Fund_Transfer : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void F_sub_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=banking_system;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
                con.Open();
                string stst = "";
                int accno = Convert.ToInt32(F_Accno.Value);
               // MessageBox.Show("no : "+accno);
                int amt = Convert.ToInt32(F_Amount.Value);
                string act = F_Action.Value;
               SqlCommand cm1= new SqlCommand($"sp_balance", con);

               // SqlCommand cm1 = new SqlCommand($"sp_Login", con);
                cm1.CommandType = System.Data.CommandType.StoredProcedure;
                cm1.Parameters.AddWithValue("@accno", accno);
                cm1.Parameters.Add("@bal", SqlDbType.Int).Direction = ParameterDirection.Output;
                cm1.ExecuteNonQuery();
                MessageBox.Show(""+ cm1.Parameters["@bal"].Value);
                int balance = 0;
                MessageBox.Show(""+balance);
                if (balance > amt)
                {
                    stst = "Success";
                }
                else
                    stst = "Failure";
                if(act=="Debit")
                    balance= balance - amt;
                else
                    balance=balance+amt;
                ///////////////
                cmd = new SqlCommand($"insert into transaction_log(Accountno,action,status,updatedon,Amount,Totalbalance) values" +
                    $"({accno},'{act}','{stst}',getdate(),'{amt}',{balance})", con);
                cmd.ExecuteNonQuery();
                ///////
                SqlCommand cmd1 = new SqlCommand($"update user_transaction set balance={balance} where accountno={accno}",con);
                cmd1.ExecuteNonQuery();
                //////
                MessageBox.Show($"Amount {amt} is successfully {act}ed");
                Response.Redirect("Bank_Home.aspx");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Account Number is incorrect!!!"+ex.Message);
            }
            finally { con.Close(); }
        }
    }
}