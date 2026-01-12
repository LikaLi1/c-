using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Employees
    {
        public string firstname;
        private string posishion;
        int salary;

        public Employees(string _firstname, string _posishion, int _salary)
        {
            firstname = _firstname;
            posishion = _posishion;
            salary = _salary;
        }
        public void print()
        {
            Console.WriteLine($"{firstname} {posishion} {salary}");
        }
        internal class Program
        {
            static void Main(string[] args)
            {

            }
        }
    }
}
