using System;

namespace TreehouseApps.Averager
{
    class Averager
    {
        static void Main()
        {
            var num = 0.0;
            var count = 0;
            double avg;
            string prompt;
            while(true)
            {
                Console.WriteLine("Enter a number or type \"done\" to see the average: ");
                prompt = Console.ReadLine();
                if(prompt.toLower() == "done")
                {
                    break;
                }
                num += double.Parse(prompt);
                count++;
            }
            avg = num / count;
            Console.WriteLine("Average: " + avg);
        }
    }
}