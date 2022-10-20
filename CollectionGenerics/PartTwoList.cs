using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionGenerics
{
    internal class PartTwoList
    { // objects created and properties initialized
        Employee employee1 = new Employee() { Name = "Sara", Gender = "Female", Id = 1303, Salary = 40000 };
        Employee employee2 = new Employee() { Name = "Lukas", Gender = "Male", Id = 1302, Salary = 22000 };
        Employee employee3 = new Employee() { Name = "Zorro", Gender = "Male", Id = 1301, Salary = 34000 };
        Employee employee4 = new Employee() { Name = "Melker", Gender = "Male", Id = 1304, Salary = 30000 };
        Employee employee5 = new Employee() { Name = "Sandra", Gender = "Female", Id = 1305, Salary = 32000 };
        List<Employee> employeeList = new List<Employee>();
        public PartTwoList()
        {
            addToList();
        }
        public void RunProgram()
        {
            string userInput = "";
            Console.Clear();
            Console.WriteLine("Checking if employee2 exists in the list");
            Program.loadingScene();
            if (employeeList.Contains(employee2)) // if employee2 exists in the list
            {
                Console.WriteLine("Employee2 exists in the list");
            }
            else
            {
                Console.WriteLine("\"Employee2 does not exist in the list");
            }
            System.Threading.Thread.Sleep(300);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("Print first Male-Employee from the list");
            Console.ResetColor();
            Program.loadingScene();
            Console.WriteLine(employeeList.Find(i => i.Gender == "Male"));   // print out first Male-employee            
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n----------------------------------------");
                Console.WriteLine("Print Employees from the list due to gender");
                Console.ResetColor();
                Console.WriteLine("#1: Print all Female");
                Console.WriteLine("#2: Print all Male");
                Console.Write("Enter option: ");
                userInput = Console.ReadLine();
                userInput = userInput.ToLower();
                if (userInput == "1" || userInput == "female")
                {
                    Program.loadingScene();
                    userInput = "Female";
                    printAllMaleOrFemale(userInput);
                    break;
                }
                else if (userInput == "2" || userInput == "male")
                {
                    Program.loadingScene();
                    userInput = "Male";
                    printAllMaleOrFemale(userInput);
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("non accepted option");
                    Console.ResetColor();
                }
            }
            Console.Write("Would you like to search for an employee by their Name or Id?[Y/N]: ");
            userInput = Console.ReadLine();
            userInput = userInput.ToLower();
            if (userInput == "y" || userInput == "yes")
            {
                searchDetails();
            }
            Console.WriteLine("\n\nBack to menu, enter key");
            Console.ReadKey();
            Console.Clear();
        }
        private void addToList() // adding object into List<>
        {
            employeeList.Add(employee1);
            employeeList.Add(employee2);
            employeeList.Add(employee3);
            employeeList.Add(employee4);
            employeeList.Add(employee5);
        }
        private void printAllMaleOrFemale(string gender)
        {
            List<Employee> employees = employeeList.FindAll(i => i.Gender == gender); // List to save all male-employees
            foreach (var printEmployees in employees) // print all male-employees
            {
                Console.WriteLine(printEmployees);
                System.Threading.Thread.Sleep(300);
            }
        }
        private void searchDetails()
        {
            string userInput = "";
            bool searchMatching = false; // if user input match an Name or Id, then = true
            Console.Write("Enter name or Id on employee: ");
            userInput = Console.ReadLine();
            foreach (var searchEmployee in employeeList)
            {
                if (searchEmployee.Name.ToLower() == userInput.ToLower() || userInput == searchEmployee.Id.ToString())
                {
                    Console.WriteLine("\nFound..");
                    System.Threading.Thread.Sleep(300);
                    Console.WriteLine(searchEmployee);
                    searchMatching = true;
                    break;
                }
            }
            if (searchMatching == false)
            {
                Console.WriteLine("\nSearching...");
                System.Threading.Thread.Sleep(300);
                Console.WriteLine("No match");
            }
            System.Threading.Thread.Sleep(300);
        }
    }
}
