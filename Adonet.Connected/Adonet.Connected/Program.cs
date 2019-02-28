using System;
using System.Data.SqlClient;

namespace Adonet.Connected
{
    class Program
    {
        static void Main(string[] args)
        {
            var comstring = Secret.shhh;

            using (var connection = new SqlConnection(comstring))
            {
                connection.Open();
                var str = "SELECT * From Movie.Movie";
                using (var command = new SqlCommand(str, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                object id = reader["MovieId"];
                                object title = reader["Title"];
                                object fullTitle = reader[4];

                                Console.WriteLine($"Movie #{id}: {fullTitle}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No more rows");
                        }

                        connection.Close();
                    }
                }
            }

        }
    }
}
