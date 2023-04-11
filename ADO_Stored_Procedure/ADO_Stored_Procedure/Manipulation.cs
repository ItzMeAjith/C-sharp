using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace ADO_Stored_Procedure
{
    internal class Manipulation
    {
        SqlConnection con;
        SqlCommand cmd;
        public void Fetch(string city)
        {
            try
            {
                con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=CIET;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");

                cmd = new SqlCommand($"detail_city", con);
                con.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@city", city);
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows==false)
                {
                    Console.WriteLine("There is no data !!!!!!!");
                }
                else
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["Rollno"] + " " + reader["stdName"] + " " + reader["stdaddress"]);
                    }
                    Console.WriteLine("Fetched Successfully");
                }
                Console.WriteLine("---------------------------------------------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong : " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void Count()
        {
            try
            {
                con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=CIET;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");

                cmd = new SqlCommand($"declare @cnt int\r\nexec detail_cnt @cnt out\r\nprint @cnt", con);
              //  cmd.Parameters.AddWithValue("@cnt"="j")
                con.Open();

                cmd.ExecuteNonQuery();
               
                Console.WriteLine("---------------------------------------------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong : " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
