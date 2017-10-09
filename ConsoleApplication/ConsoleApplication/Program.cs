using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello World";
            string input = "Ramanpreet Chand";

            Console.Write(greeting + ' ');
            Console.WriteLine(SplitName(input)[0]);
        }
        
        static string[] SplitName(string input)
        {
            return input.Split(' ');
        }
    }
}
