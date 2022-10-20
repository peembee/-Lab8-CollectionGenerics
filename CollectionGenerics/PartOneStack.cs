using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionGenerics
{
    internal class PartOneStack
    {// objects created and properties initialized
        Employee employee1 = new Employee() { Name = "Johan", Gender = "Male", Id = 1201, Salary = 32000 };
        Employee employee2 = new Employee() { Name = "Oskar", Gender = "Male", Id = 1202, Salary = 28000 };
        Employee employee3 = new Employee() { Name = "Saga", Gender = "Female", Id = 1203, Salary = 38000 };
        Employee employee4 = new Employee() { Name = "Malte", Gender = "Male", Id = 1204, Salary = 28000 };
        Employee employee5 = new Employee() { Name = "Lovisa", Gender = "Female", Id = 1205, Salary = 30000 };
        Stack<Employee> employeeStack = new Stack<Employee>();
        public PartOneStack()
        {
            addToStack();
        }
        public void RunProgram()
        {
            int nrOfElementsInStack;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n------------------------");
            Console.WriteLine("Printing stack...");
            Console.WriteLine();
            Console.ResetColor();
            foreach (var displayEmployees in employeeStack)
            {
                Console.WriteLine(displayEmployees);
                Console.WriteLine("Items left in stack: " + employeeStack.Count);
                Console.WriteLine("----------------------------------------------\n");
                System.Threading.Thread.Sleep(500);
            }
            Console.WriteLine("Enter key for use the PoP Method:");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("------------------------");
            Console.WriteLine("Retrive using pop method");
            Console.WriteLine();
            nrOfElementsInStack = employeeStack.Count;
            for (int i = 0; i < nrOfElementsInStack; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Items left in stack: " + employeeStack.Count);
                Console.ResetColor();
                foreach (var displayEmployees in employeeStack)
                {
                    Console.WriteLine(displayEmployees);
                    System.Threading.Thread.Sleep(200);
                }
                System.Threading.Thread.Sleep(300);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("***********");
                Console.WriteLine(employeeStack.Pop() + " just left the stack");
                Console.WriteLine("***********");
                System.Threading.Thread.Sleep(300);
            }
            Console.ResetColor();
            Console.WriteLine("\n----------------------------------------------");
            Console.WriteLine("Items left in stack: " + employeeStack.Count);
            Console.WriteLine("----------------------------------------------");
            System.Threading.Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Stack with the same data implemented");
            Console.WriteLine("--------------------------");
            Console.ResetColor();
            addToStack();
            foreach (var displayEmployees in employeeStack)
            {
                Console.WriteLine(displayEmployees);
            }
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("\nEnter key for use the Peek Method:");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n------------------------");
            Console.WriteLine("Retrive using peek method");
            Console.WriteLine();
            Console.ResetColor();
            for (int i = 0; i < 2; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Items left in stack: " + employeeStack.Count);
                Console.ResetColor();
                System.Threading.Thread.Sleep(300);
                Console.WriteLine(employeeStack.Peek());
            }
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("\nEnter key for search for the item #3 in the stack");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n------------------------");
            Console.WriteLine("Checking element #3");
            Program.loadingScene();
            Console.ResetColor();
            if (employeeStack.Contains(employee3))
            {
                Console.WriteLine("Item #3 found: " + employeeStack.ToArray()[2]);
            }
            else
            {
                Console.WriteLine("Item #3 does not exist ");
                Console.WriteLine(employeeStack.Count());
            }
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("\n\nBack to menu, enter key");
            Console.ReadKey();
            Console.Clear();
        }
        private void addToStack() // adding object into stack><
        {
            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);
        }
    }
}
