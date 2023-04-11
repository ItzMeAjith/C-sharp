using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
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
        private object sqlDbType;

        public void Search(string dep)
        {
            try
            {
                con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=CIET;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");

                cmd = new SqlCommand($"detail_dept", con);
                con.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dep", dep);
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows==false)
                {
                    Console.WriteLine("There is no data !!!!!!!");
                }
                else
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["Rollno"] + " " + reader["Name"] + " " + reader["dept"]+" " + reader["cgpa"]);
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
        public void Fetch()
        {
            try
            {
                con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=CIET;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");

                cmd = new SqlCommand($"select * from students", con);
                //  cmd.Parameters.AddWithValue("@cnt"="j")
                con.Open();

                SqlDataReader rd= cmd.ExecuteReader();
                if(rd.HasRows==false)
                {
                    Console.WriteLine("No data found !!!!!");
                }
                else
                {
                    while (rd.Read())
                    {
                        Console.WriteLine(rd["rollno"]+" " + rd["name"]+" " + rd["dept"]+" " + rd["cgpa"]);
                    }
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
        public void Count(string dep)
        {
            int count = 0;
            try
            {
                con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=CIET;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
                con.Open();
                cmd = new SqlCommand($"student_dept_cnt", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dep", dep);
                cmd.Parameters.Add("@cnt", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                count = (int)cmd.Parameters["@cnt"].Value;
                Console.WriteLine($"The totat students in {dep} department is  : "+count);
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
