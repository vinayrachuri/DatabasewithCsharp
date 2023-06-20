using System.Data.SqlClient;
using System.Data;

namespace Dataviewinsert
{
    public class Program
    {
        public static void Main()
        {
            string connectionString = "Data Source=VINAYGUPTA;Initial Catalog=CowosDatabase;Integrated Security=True";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Select an operation:");
                Console.WriteLine("1. Display table data");
                Console.WriteLine("2. Insert data");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                if (choice == "0")
                    break;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    switch (choice)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("Select a table to display its data:");
                            Console.WriteLine("1. WorkSpaceType");
                            Console.WriteLine("2. WorkSpaceCategory");
                            Console.WriteLine("3. IdentityType");
                            Console.WriteLine("4. FacilityType");
                            Console.Write("Enter your choice: ");
                            string tableChoice = Console.ReadLine();

                            switch (tableChoice)
                            {
                                case "1":
                                    DataView.DisplayTableData("dbo.WorkSpaceType");
                                    break;
                                case "2":
                                    DataView.DisplayTableData("dbo.WorkSpaceCategory");
                                    break;
                                case "3":
                                    DataView.DisplayTableData("dbo.IdentityType");
                                    break;
                                case "4":
                                    DataView.DisplayTableData("dbo.FacilityType");
                                    break;
                                default:
                                    Console.WriteLine("Invalid table choice.");
                                    break;
                            }

                            break;

                        case "2":
                            Console.Clear();
                            Console.WriteLine("Select a table to insert data into:");
                            Console.WriteLine("1. WorkSpaceType");
                            Console.WriteLine("2. WorkSpaceCategory");
                            Console.WriteLine("3. IdentityType");
                            Console.WriteLine("4. FacilityType");
                            Console.Write("Enter your choice: ");
                            string insertTableChoice = Console.ReadLine();

                            switch (insertTableChoice)
                            {
                                case "1":
                                    Datainsert.InsertData("dbo.WorkSpaceType");
                                    break;
                                case "2":
                                    Datainsert.InsertData("dbo.WorkSpaceCategory");
                                    break;
                                case "3":
                                    Datainsert.InsertData("dbo.IdentityType");
                                    break;
                                case "4":
                                    Datainsert.InsertData("dbo.FacilityType");
                                    break;
                                default:
                                    Console.WriteLine("Invalid table choice.");
                                    break;
                            }

                            break;

                        default:
                            Console.WriteLine("Invalid choice. Press any key to try again...");
                            Console.ReadKey();
                            continue;
                    }
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}