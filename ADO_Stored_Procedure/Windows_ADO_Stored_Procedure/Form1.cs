using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_ADO_Stored_Procedure
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cty = city.Text;
            con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=CIET;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");

            cmd = new SqlCommand($"detail_city", con);
            con.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@city", cty);
            SqlDataReader reader = cmd.ExecuteReader();
           if(reader.HasRows==false) 
            {
                MessageBox.Show("No data found!!!");
            }
           else
            {
                DataTable tb = new DataTable();
                tb.Load(reader);
                dataGridView1.DataSource = tb;
                MessageBox.Show("Ready");
            }
            con.Close();
            
            
        }
    }
}
