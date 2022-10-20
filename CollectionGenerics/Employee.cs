using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionGenerics
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Id { get; set; }
        public int Salary { get; set; }
        private string PrintInfo()
        {
            return "Name: " + Name + ". ID: " + Id + ". Gender: " + Gender + ". Salary: " + Salary;
        }
        public override string ToString()
        {
            return PrintInfo();
        }
    }
}
