using System;
using System.IO;
using System.Text;
using Xunit;
using FluentAssertions;
using Refactoring.ExtractMethod;

namespace Refactoring.Tests.ExtractMethod
{
    public class PrintOwingTest
    {
        private const double Amount = 8.0;
        private const string Name = "Name";

        
        [Fact]
        public void TestPrintOwing()
        {
            var memoryStream = new MemoryStream();
            StreamWriter sw = new StreamWriter(memoryStream);
            sw.AutoFlush = true;
            Console.SetOut(sw);
            
            var person = new Person(Name);

            person.PrintOwing(Amount);

            Encoding.ASCII.GetString(memoryStream.ToArray()).Should().Be($"Person has: name: {Name}, amount: {Amount}");
        }
    }
}