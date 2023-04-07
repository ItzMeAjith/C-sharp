using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO1
{
    internal class Manipulations
    {
        // CREATE--------------------------------------
        public void Create()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=CIET;integrated security=SSPI;");

                SqlCommand cmd = new SqlCommand("create table ADOdepartment(Roll int primary key,Name varchar(30))", con);
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Successfully created the table");
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
        //INSERT-------------------------------------
        public void Insert(int roll,string name)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=CIET;integrated security=SSPI;");

                SqlCommand cmd = new SqlCommand($"insert into ADOdepartment values ({roll},'{name}')", con);
                con.Open();
                cmd.ExecuteNonQuery();

                Console.WriteLine("Inserted Successfully");
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
        //UPDATE-------------------------------------
        public void Update(int roll, string name)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=CIET;integrated security=SSPI;");

                SqlCommand cmd = new SqlCommand($"update ADOdepartment set Name='{name}' where Roll={roll}", con);
                con.Open();
                cmd.ExecuteNonQuery();

                Console.WriteLine("Updated Successfully");
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
        //---------
        public void Update(int pos, int roll)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=CIET;integrated security=SSPI;");

                SqlCommand cmd = new SqlCommand($"update ADOdepartment set Roll={roll} where Roll={pos}", con);
                con.Open();
                cmd.ExecuteNonQuery();

                Console.WriteLine("Updated Successfully");
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
        //DELETE---------
        public void Delete(int roll)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=CIET;integrated security=SSPI;");

                SqlCommand cmd = new SqlCommand($"detete from ADOdepartment where Roll={roll}", con);
                con.Open();
                cmd.ExecuteNonQuery();

                Console.WriteLine("Deleted Successfully");
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
        //FETCH---------
        public void Fetch()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=CIET;integrated security=SSPI;");

                SqlCommand cmd = new SqlCommand($"Select * from ADOdepartment", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["Roll"] + " " + reader["Name"]);
                }
                Console.WriteLine("Fetched Successfully");
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
