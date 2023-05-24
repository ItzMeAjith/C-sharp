using System;
using System.Data.SqlClient;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection connection = new SqlConnection("data source=DESKTOP-GL7RKG7\\SQLEXPRESS; database=CIET;integrated security=SSPI;"))
            {
                connection.Open();

                // Read the image file into a byte array
                byte[] imageData = File.ReadAllBytes("H:\\Ajith\\Ajith.jpg");

                // Prepare the SQL statement with a parameter for the image data
                string sql = $"update clg_depts set stdphoto=@ImageData where rollno=2";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Bind the image data to the parameter
                    command.Parameters.AddWithValue("@ImageId", 1);
                    command.Parameters.AddWithValue("@ImageData", imageData);

                    // Execute the SQL statement
                    command.ExecuteNonQuery();
                    Console.WriteLine(imageData);
                }
            }

        }
    }
}