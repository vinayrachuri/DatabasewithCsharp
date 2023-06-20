using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Dataviewinsert
{
    public class DataView
    {
        public const string ConnectionString = "Data Source=VINAYGUPTA;Initial Catalog=CowosDatabase;Integrated Security=True";

        public static void DisplayTableData(string tableName)
        {
            string idColumnName;
            string nameColumnName;

            switch (tableName)
            {
                case "dbo.WorkSpaceType":
                    idColumnName = "WorkspaceTypeId";
                    nameColumnName = "Name";
                    break;
                case "dbo.WorkSpaceCategory":
                    idColumnName = "WorkSpaceCategoryID";
                    nameColumnName = "Name";
                    break;
                case "dbo.IdentityType":
                    idColumnName = "IdentityTypeID";
                    nameColumnName = "Name";
                    break;
                case "dbo.FacilityType":
                    idColumnName = "FacilityTypeID";
                    nameColumnName = "Name";
                    break;
                default:
                    Console.WriteLine("Invalid table name.");
                    return;
            }

            string query = $"SELECT {idColumnName}, {nameColumnName} FROM {tableName}";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine($"Data from table '{tableName}':");
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);

                            Console.WriteLine($"ID: {id}, Name: {name}");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
