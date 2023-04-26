using System;
using System.Data;
using System.Data.SqlClient;
namespace AFTER_UTUBE_DISCONNECTED
{ 
    class Mani
    {
        public void fetch()
        {
            try
            {
                SqlConnection con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=CIET;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
                SqlCommand cmd = new SqlCommand("SELECT * FROM Students", con);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ad.Fill(ds);
                Console.WriteLine($"Rollno  Name  Department  CGPA");
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Console.WriteLine($"{dr[0]}  {dr[1]}  {dr[2]}  {dr[3]}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong :" + ex.Message);
            }
        }
        public void insert()
        {
            try
            {
                SqlConnection con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=CIET;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
                SqlCommand cmd = new SqlCommand("SELECT * FROM Students", con);
                DataSet ds= new DataSet();
                DataRow dr=new
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong :" + ex.Message);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Mani m=new Mani();
            m.fetch();
        }
    }
}