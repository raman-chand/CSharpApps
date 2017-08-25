/*
Write an interactive quiz. 
It should ask the user three multiple-choice or true/false questions about something. 
It must keep track of how many they get wrong, and print out a "score" at the end. 
*/
using System;

namespace TreehouseApps.InteractiveQuiz
{
    class InteractiveQuiz
    {
        static void Main()
        {
            int correct = 0;
            int wrong = 0;

            Console.WriteLine("Welcome to Raman's Interactive Quiz! \nAnswer the following questions, and I'll tell you how many you answered correctly and incorrectly.");

            Console.WriteLine("How many states are in the United States?");
            string ans1 = Console.ReadLine();

            Console.WriteLine("There are 7 wonders of the world. (T/F)");
            string ans2 = Console.ReadLine();

            Console.WriteLine("What year was Treehouse founded?");
            string ans3 = Console.ReadLine();

            if (ans1 == "50")
            {
                correct++;    
            }
            else
            {
                wrong++;
            }
            if (ans2.ToUpper() == "T" || ans2.ToLower() == "true")
            {
                correct++;
            }
            else
            {
                wrong++;
            }
            if(ans3 == "2011")
            {
                correct++;
            }
            else
            {
                wrong++;
            }

            if(wrong == 0)
            {
                Console.WriteLine("Congratulations!");
            }
            else if(wrong == 1)
            {
                Console.WriteLine("Good Job!");
            }
            else if(wrong == 2)
            {
                Console.WriteLine("You did your best.");
            }
            else
            {
                Console.WriteLine("You should try again.");
            }

            Console.WriteLine("Correct: " + correct);
            Console.WriteLine("Incorrect: " + wrong);
        }
    }
}