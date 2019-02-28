using System;
using System.Data;
using System.Data.SqlClient;


namespace ADONetdisconnected
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter condition!");

            var condition = Console.ReadLine();

            var dataset = new DataSet();


            var connection = Secret.shhh;



            using (var connectionn = new SqlConnection(connection))
            {
                connectionn.Open();
                var commandstring = "an actuall sql command line";

                using (var command = new SqlCommand(commandstring, connectionn))
                using (var adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataset);
                }

                connectionn.Close();
            }

            foreach(DataRow item in dataset.Tables[0].Rows)
            {
                DataColumn idCol = dataset.Tables[0].Columns["GenreId"];
                Console.WriteLine($"The output. #{item[idCol]}");
            }

        }
    }
}
