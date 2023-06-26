using System;

namespace BusinessLayer
{
    public class BusinessOperations
    {
        private readonly DataLayer.DataOperations dataOperations;

        public BusinessOperations(string connectionString)
        {
            dataOperations = new DataLayer.DataOperations(connectionString);
        }

        public void PerformOperation(string choice, int groupId = 0)
        {
            switch (choice)
            {
                case "1":
                    DisplayTableOptions();
                    string tableChoice = Console.ReadLine();
                    DisplayTableData(tableChoice);
                    break;

                case "2":
                    DisplayInsertTableOptions();
                    string insertTableChoice = Console.ReadLine();

                    // Check the insert table choice and provide the correct table name
                    string tableName = "";
                    switch (insertTableChoice)
                    {
                        case "1":
                            tableName = "dbo.WorkSpaceType";
                            break;
                        case "2":
                            tableName = "dbo.WorkSpaceCategory";
                            break;
                        case "3":
                            tableName = "dbo.IdentityType";
                            break;
                        case "4":
                            tableName = "dbo.FacilityType";
                            break;
                        default:
                            Console.WriteLine("Invalid table choice.");
                            break;
                    }

                    dataOperations.InsertData(tableName);
                    break;

                case "3":
                    dataOperations.DisplayWorkspaceGroups();
                    break;

                case "4":
                    if (groupId == 0)
                    {
                        Console.Write("Enter the Workspace Group ID: ");
                        groupId = int.Parse(Console.ReadLine());
                    }
                    dataOperations.DisplayWorkspacesByGroup(groupId);
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        public void DisplayTableOptions()
        {
            Console.WriteLine("Select a table to display its data:");
            Console.WriteLine("1. WorkSpaceType");
            Console.WriteLine("2. WorkSpaceCategory");
            Console.WriteLine("3. IdentityType");
            Console.WriteLine("4. FacilityType");
            Console.WriteLine("5. WorkSpace");
            Console.WriteLine("6. WorkspaceGroup");
            Console.Write("Enter your choice: ");
        }

        public void DisplayInsertTableOptions()
        {
            Console.WriteLine("Select a table to insert data into:");
            Console.WriteLine("1. WorkSpaceType");
            Console.WriteLine("2. WorkSpaceCategory");
            Console.WriteLine("3. IdentityType");
            Console.WriteLine("4. FacilityType");
            Console.Write("Enter your choice: ");
        }

        public void DisplayTableData(string tableChoice)
        {
            switch (tableChoice)
            {
                case "1":
                    dataOperations.DisplayData("dbo.WorkSpaceType");
                    break;
                case "2":
                    dataOperations.DisplayData("dbo.WorkSpaceCategory");
                    break;
                case "3":
                    dataOperations.DisplayData("dbo.IdentityType");
                    break;
                case "4":
                    dataOperations.DisplayData("dbo.FacilityType");
                    break;
                case "5":
                    dataOperations.DisplayData("dbo.WorkSpace");
                    break;
                case "6":
                    dataOperations.DisplayData("dbo.WorkspaceGroup");
                    break;
                default:
                    Console.WriteLine("Invalid table choice.");
                    break;
            }
        }
    }
}
