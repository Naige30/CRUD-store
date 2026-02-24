
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace CRUDSTORE
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string[] storeNames = { "Ligaya Store", "Boni Store", "Ledezma Enterprise" };

            Console.WriteLine("1. Add Store");
            Console.WriteLine("2. View Store");
            Console.WriteLine("3. Update Store");
            Console.WriteLine("4. Delete Store");
            Console.WriteLine("Enter your choice:");
            int choice = Convert.ToInt16(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStore();
                    break;
                case 2:
                    ViewStore();
                    break;
                case 3:
                    UpdateStore();
                    break;
                case 4:
                    DeleteStore();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        static void AddStore()
        {
            Console.WriteLine("Enter store name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter store location:");
            string location = Console.ReadLine();
            Console.WriteLine("Enter store profits: ");
            double profits = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter store expenses: ");
            double expenses = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter store employees: ");
            int employees = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter store products: ");
            int products = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Store added successfully");
        }

        static void ViewStore()
        {
            Console.WriteLine("Enter store name to view:");
            string storename = Console.ReadLine();
            if (storename == "Ligaya Store")
            {
                Console.WriteLine("Store Name: Ligaya Store");
                Console.WriteLine("Store Location: Muntinlupa City");
                Console.WriteLine("Store Profits: 500000");
                Console.WriteLine("Store Expenses: 200000");
                Console.WriteLine("Store Employees: 150");

            }
            else if (storename == "Boni Store")
            {
                Console.WriteLine("Store Name: Boni Store");
                Console.WriteLine("Store Location: Mandaluyong City");
                Console.WriteLine("Store Profits: 300000");
                Console.WriteLine("Store Expenses: 100000");
                Console.WriteLine("Store Employees: 100");
            }
            else if (storename == "Ledezma Enterprise")
            {
                Console.WriteLine("Store Name: Ledezma Enterprise");
                Console.WriteLine("Store Location: Pasig City");
                Console.WriteLine("Store Profits: 400000");
                Console.WriteLine("Store Expenses: 150000");
                Console.WriteLine("Store Employees: 120");
            }
            else
            {
                Console.WriteLine("Store not found");
            }

        }
        static void UpdateStore()
        {
            Console.WriteLine("Enter store name to update:");
            string storename = Console.ReadLine();
            if (storename == string[] storeNames)
            {
            }
        }
        static void DeleteStore()
        {
            Console.WriteLine("Enter store name to delete:");
            string storename = Console.ReadLine();
            if (storename == string[] storeNames)
            {
            }
        }
    }
}
