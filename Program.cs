
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace CRUDSTORE
{
    class Store
    {
        public string Name;
        public string Location;
        public double Profits;
        public double Expenses;
        public int Employees;
        public int Products;
    }
    internal class Program
    {

        static List<Store> stores = new List<Store>()
        {
            new Store{Name="Ligaya Store",Location="Muntinlupa City",Profits=500000,Expenses=200000,Employees=150,Products=1000},
            new Store{Name="Boni Store",Location="Mandaluyong City",Profits=300000,Expenses=100000,Employees=100,Products=500},
            new Store{Name="Ledezma Enterprise",Location="Pasig City",Profits=400000,Expenses=150000,Employees=120,Products=800}
        };


        static void Main(string[] args)
        {
            string[] storeNames = { "Ligaya Store", "Boni Store", "Ledezma Enterprise" };
            Console.WriteLine("===STORE MENU===");
            Console.WriteLine("1. Add Store");
            Console.WriteLine("2. View Store");
            Console.WriteLine("3. Update Store");
            Console.WriteLine("4. Delete Store");
            Console.WriteLine("0. Exit");
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
                case 0:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        static void AddStore()
        {
            Store s = new Store();
            Console.WriteLine("Enter store name:");
            s.Name = Console.ReadLine();
            Console.WriteLine("Enter store location:");
            s.Location = Console.ReadLine();
            Console.WriteLine("Enter store profits: ");
            s.Profits = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter store expenses: ");
            s.Expenses = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter store employees: ");
            s.Employees = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter store products: ");
            s.Products = Convert.ToInt16(Console.ReadLine());
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
