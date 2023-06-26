using BusinessLayer;
using System;

namespace DbCrudOperations
{
    class Program
    {
        static void Main()
        {
            string connectionString = "Data Source=VINAYGUPTA;Initial Catalog=CowosDatabase;Integrated Security=True";

            BusinessOperations businessOperations = new BusinessOperations(connectionString);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Select an operation:");
                Console.WriteLine("1. Display table data");
                Console.WriteLine("2. Insert data");
                Console.WriteLine("3. Display workspace groups");
                Console.WriteLine("4. Display workspaces by group");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                if (choice == "0")
                    break;

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        businessOperations.PerformOperation(choice);
                        break;

                    case "2":
                        Console.Clear();
                        businessOperations.PerformOperation(choice);
                        break;

                    case "3":
                        Console.Clear();
                        businessOperations.PerformOperation(choice);
                        break;

                    case "4":
                        Console.Clear();
                        Console.Write("Enter the Workspace Group ID: ");
                        int groupId = int.Parse(Console.ReadLine());
                        businessOperations.PerformOperation(choice, groupId);
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
            }
        }
    }
}
