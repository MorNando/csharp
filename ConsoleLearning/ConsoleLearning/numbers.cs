using System;
using System.Collections.Generic;

namespace ConsoleLearning
{
    public class numbers
    {
        public static void add()
        {

            string answer;
            decimal number = 0;
            do
                {                    
                    
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Enter a number to add to {0}, or type \"ok\" to end", number);
                    answer = Console.ReadLine();

                    decimal result;
                    bool isNumeric = decimal.TryParse(answer, out result);

                    if (isNumeric == true)
                    {
                        number += decimal.Parse(answer);
                        Console.Clear();

                    } else if (answer != "ok" && isNumeric == false)
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\"{0}\" is not a number or the word \"ok\". Please try again\n", answer);

                    }
            
                } while (answer != "ok");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nYour final number is {0}\n", number);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void factoral()
        {
            Console.WriteLine("What is your number to factor:");
            int number = int.Parse(Console.ReadLine());

            for ( int x = number -1; x >= 1; x--)
            {

                number = number * x;

            }

            Console.WriteLine("The factoral number is: {0}", number);

        }

        public static void randomnumber()
        {

            System.Random number = new System.Random();
            int randomnumber = number.Next(1,7);
            string guess;
            int guessfinal = 0;
            Console.WriteLine("Hint: The random number is {0}\n", randomnumber);
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Take a guess at a number between 1 and 6:");
                guess = Console.ReadLine();
                bool guessparse = int.TryParse(guess, out int guessvar);

                if (guessparse != true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n{0} isn't a whole number between 1 and 6\n", guess);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    guessfinal = int.Parse(guess);
                    if (randomnumber != guessfinal)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nSorry but that is incorrect. Try again.\n");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

            } while (randomnumber != guessfinal);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCongratulations you have won!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void largestnumber()
        {
            Console.WriteLine("Type a comma seperated list of numbers to find out the largest:");
            var input = Console.ReadLine();
            var list = new List<string>(input.Split(','));
            var largest = 0;

            foreach (var l in list)
            {
                if (int.Parse(l) > largest)
                {
                    largest = int.Parse(l);
                }
            }

            Console.WriteLine("\nthe largest number is {0}\n", largest);
        }
    }
}
