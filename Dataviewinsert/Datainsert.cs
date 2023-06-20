using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Datainsert
{
    public const string ConnectionString = "Data Source=VINAYGUPTA;Initial Catalog=CowosDatabase;Integrated Security=True";

    public static void InsertData(string tableName)
    {
        Console.WriteLine($"Inserting into {tableName} table...");
        Console.Write("Enter the value: ");
        string value = Console.ReadLine();

        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            connection.Open();
            string query = $"INSERT INTO {tableName} (Name) VALUES (@Value)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Value", value);
            command.ExecuteNonQuery();
        }

        Console.WriteLine("Data inserted successfully.");
    }
}
