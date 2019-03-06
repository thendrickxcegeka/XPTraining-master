using System;
using System.Text;

namespace Refactoring.ExtractMethod
{
    public class Person
    {
        private string _name;

        public Person(string name)
        {
            _name = name;
        }

        public void PrintOwing(double amount)
        {
            PrintBanner();

            //		print details
            Console.Write("name: " + _name);
            Console.Write(", amount: " + amount);
        }

        private void PrintBanner() => Console.Write("Person has: ");
    }
}