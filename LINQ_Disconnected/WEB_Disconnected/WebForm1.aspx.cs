using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WEB_Disconnected
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter ad;

        protected void Page_Load(object sender, EventArgs e)
        {

            con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=CIET;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
            cmd = new SqlCommand("SELECT * FROM Students", con);
            ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            DataTable tbl = new DataTable();
            ad.Fill(tbl);
            if (!ds.Tables.Contains("Students"))
            {
                // Create the Employee table
                DataTable employeeTable = new DataTable("Students");
                employeeTable.Columns.Add("Rollno", typeof(int));
                employeeTable.Columns.Add("Name", typeof(string));
                employeeTable.Columns.Add("Dept", typeof(string));
                employeeTable.Columns.Add("CGPA", typeof(double));
                ds.Tables.Add(employeeTable);
            }
            
        }

        
        
    }
}