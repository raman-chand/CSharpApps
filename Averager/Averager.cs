using System;

namespace TreehouseApps.Averager
{
    class Averager
    {
        static double CalculateAverage(double num, int count)
        {
            double avg = num / count;
            return avg;
        }
        static void Main()
        {
            var num = 0.0;
            var count = 0;
            string prompt;
            while (true)
            {
                Console.WriteLine("Enter a number or type \"done\" to see the average: ");
                prompt = Console.ReadLine();
                if (prompt.ToLower() == "done")
                {
                    break;
                }
                num += double.Parse(prompt);
                count++;
            }
            var avg = CalculateAverage(num, count);
            Console.WriteLine("Average: " + avg);
        }
    }
}