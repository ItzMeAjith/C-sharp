using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO_Windows_Application
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=CIET;integrated security=SSPI;");
                con.Open();
                int rol = Convert.ToInt32(roll.Text);
                string n = name.Text;
                string d = dept.Text;
                double cg = Convert.ToDouble(cgpa.Text);
                cmd = new SqlCommand($"insert into Students values({rol},'{n}','{d}',{cg})", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student details inserted successfully!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong : " + ex.Message);
            }
            finally { con.Close(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=CIET;integrated security=SSPI;");
                con.Open();
                cmd = new SqlCommand($"select * from Students", con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable tbl = new DataTable();
                tbl.Load(dr);
                dataGridView1.DataSource = tbl;
                MessageBox.Show("Your data is ready!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong : " + ex.Message);
            }
            finally { con.Close(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int rol = Convert.ToInt32(roll.Text);
                string n = name.Text;
                string d = dept.Text;
                double cg = Convert.ToDouble(cgpa.Text);
                con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=CIET;integrated security=SSPI;");
                con.Open();
                cmd = new SqlCommand($"update Students set Name='{n}',dept='{d}',cgpa='{cg}' where Rollno={rol}", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your data updated!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong : " + ex.Message);
            }
            finally { con.Close(); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int rol = Convert.ToInt32(roll.Text);
                string n = name.Text;
                string d = dept.Text;
                double cg = Convert.ToDouble(cgpa.Text);
                con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=CIET;integrated security=SSPI;");
                con.Open();
                cmd = new SqlCommand($"delete from Students where rollno={rol}", con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable tbl = new DataTable();
                tbl.Load(dr);
                dataGridView1.DataSource = tbl;
                MessageBox.Show($"Roll no: {rol} deleted successfully!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong : " + ex.Message);
            }
            finally { con.Close(); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=CIET;integrated security=SSPI;");
                con.Open();
                cmd = new SqlCommand($"select * from Students", con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable tbl = new DataTable();
                tbl.Load(dr);
                dataGridView1.DataSource = tbl;
    
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong : " + ex.Message);
            }
            finally { con.Close(); }
        }
    }
}
