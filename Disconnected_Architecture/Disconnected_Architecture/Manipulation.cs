using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Disconnected_Architecture
{
    internal class Manipulation
    {
        SqlConnection con;
        SqlCommand cmd;
        public void Fetch()
        {
            try
            {
                con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=CIET;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
                cmd = new SqlCommand("SELECT * FROM Students", con);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ad.Fill(ds,"Students");
                foreach (DataRow dr in ds.Tables["Students"].Rows)
                {
                    //Console.WriteLine($"{dr[0]} {dr[1]} {dr[2]} {dr[3]}");
                    Console.WriteLine(dr[0]);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Something went wrong : " + ex.Message);
            }
            
        }
        public void Insert(int roll,string name,string dept,double cgpa)
        {
            try
            {
                con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=CIET;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
                cmd = new SqlCommand($"INSERT INTO Students values({roll},'{name}','{dept}','{cgpa}')", con);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                //ad.Update();
                Console.WriteLine("Inserted successfully !!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong : " + ex.Message);
            }

        }
    }
}
