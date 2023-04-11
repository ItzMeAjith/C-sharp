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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

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

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=CIET;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
            con.Open();
            cmd = new SqlCommand($"detail_std", con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Load(dr);
            dataGridView1.DataSource = tbl;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=CIET;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
            con.Open();
            cmd = new SqlCommand($"detail_std", con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Load(dr);
            dataGridView1.DataSource = tbl;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dept = dep.Text;
            con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=CIET;integrated security=SSPI;");
            cmd = new SqlCommand($"detail_dept", con);
            con.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dep", dept);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Load(dr);
            dataGridView1.DataSource = tbl;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = 0;
            string dept = dep.Text;
            con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=CIET;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
            con.Open();
            cmd = new SqlCommand($"student_dept_cnt", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dep", dept);
            cmd.Parameters.Add("@cnt", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            count = (int)cmd.Parameters["@cnt"].Value;
            //Console.WriteLine("The count is : " + count);
            MessageBox.Show($"The totat students in {dept} department is  : " + count);
        }

        private void dep_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
