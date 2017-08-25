/*
Create a calculator that does one arithmetic operation at a time 
and prints the result to the screen.
    -Prompt the user for a number.
    -Prompt the user for an operation (+ - / *).
    -Prompt the user for another number.
    -Perform the operation.
    -Print the result to the screen.
    -Repeat until the user types in “quit” at any of the prompts.
Extra Credit: Add the power operator using the ^ symbol. 
You can calculate a number raised to a power using the Math.Pow method. 
 */
 using System;

 namespace TreehouseApps.ArithmeticCalculator
 {
    class ArithmeticCalculator
    {
        static void Exponential(double num1, double num2)
        {
            var total = Math.Pow(num1, num2);
            Console.WriteLine("Total: " + total);
        }
        static void Divide(double num1, double num2)
        {
            var total = num1 / num2;
            Console.WriteLine("Total: " + total);
        }
        static void Multiply(double num1, double num2)
        {
            var total = num1 * num2;
            Console.WriteLine("Total: " + total);
        }
        static void Subtract(double num1, double num2)
        {
            var total = num1 - num2;
            Console.WriteLine("Total: " + total);
        }
        static void Sum(double num1, double num2)
        {
            var total = num1 + num2;
            Console.WriteLine("Total: " + total);
        }
        static string GetANumber()
        {
            Console.WriteLine("Give me a number:");
            var input = Console.ReadLine();
            return input;
        }
        static string ShowMenu()
        {
            Console.WriteLine("Pick an operation (1-4):");
            Console.WriteLine("1. +");
            Console.WriteLine("2. -");
            Console.WriteLine("3. *");
            Console.WriteLine("4. /");
            Console.WriteLine("5. ^");
            Console.WriteLine("0. Exit");

            var pick = Console.ReadLine();
            return pick;
        }
        static void Main()
        {
            while (true)
            {
                var pick = ShowMenu();

                if (pick == "0")
                {
                    Console.WriteLine("Goodbye.");
                    break;
                }
                else
                {
                    var ans1 = GetANumber();
                    var ans2 = GetANumber();
                    var num1 = double.Parse(ans1);
                    var num2 = double.Parse(ans2);

                    if (pick == "1")
                    {
                        Sum(num1, num2);
                    }
                    else if (pick == "2")
                    {
                        Subtract(num1, num2);
                    }
                    else if (pick == "3")
                    {
                        Multiply(num1, num2);
                    }
                    else if (pick == "4")
                    {
                        Divide(num1, num2);
                    }
                    else if (pick == "5")
                    {
                        Exponential(num1, num2);
                    }
                }
            }
        }
    }
}