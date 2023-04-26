using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BANK_MANAGEMENT_SYSTEM
{
    public partial class Bank_Home : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {

        }

        protected void transact_Click(object sender, EventArgs e)
        {
            Response.Redirect("Transactions.aspx");

        }

        protected void fundTrans_Click(object sender, EventArgs e)
        {
            Response.Redirect("Fund_Transfer.aspx");
        }

        protected void home_Click(object sender, EventArgs e)
        {
           // Response.Redirect("Application_Form.aspx");
        }

        protected void appform_Click(object sender, EventArgs e)
        {
            Response.Redirect("Application_Form.aspx");
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("User_Registration.aspx");
        }

        protected void go_Click(object sender, EventArgs e)
        {
            int accno =Convert.ToInt32(sear.Value);
            con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=banking_system;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
            con.Open();
            cmd = new SqlCommand($"select * from Accountant_details where accountno={accno}", con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            USertbl.DataSource = dt;
            USertbl.DataBind();
        }
    }
}