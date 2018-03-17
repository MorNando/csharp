using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLearning
{
    public class lists
    {
        public static void facebooklikes()
        {
            var names = new List<string>();
            string name;
            do
            {
                Console.Clear();

                if (names.Count == 1)
                {
                    var firstLike = Convert.ToString(names[0]);
                    Console.WriteLine("{0} liked your post.\n\n", firstLike );
                }

                else if (names.Count == 2)
                {
                    var firstLike = Convert.ToString(names[0]);
                    var secondLike = Convert.ToString(names[1]);
                    Console.WriteLine("{0} and {1} liked your post.\n\n", firstLike,secondLike);
                }
                
                else if (names.Count > 2)
                {
                    var theRest = names.Count - 2;
                    var firstLike = Convert.ToString(names[0]);
                    var secondLike = Convert.ToString(names[1]);

                    if (theRest == 1)
                    {
                        Console.WriteLine("{0}, {1} and " + theRest + " other liked your post.\n\n", firstLike, secondLike);
                    }
                    else
                    {
                        Console.WriteLine("{0}, {1} and " + theRest + " others liked your post.\n\n", firstLike, secondLike);
                    }
                }

                Console.WriteLine("Type a name to like your post. Type \"ok\" to finish.");
                name = Console.ReadLine();
                if (name != null)
                {
                    names.Add(name);
                }
            } while (name != "ok");

        }
        
        public static void reversename()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            int size = name.Length;
            char character;
            char[] characters = new char[size];
            for (int i = 0; i < name.Length; i++)
            {

                character = name[i];
                characters[i] = character;

            }

            Array.Reverse(characters);
            string reversename = new string(characters);
            Console.WriteLine("Your reverse name is {0}", reversename);
        }

        public static void fivenumbers()
        {

            int[] numbers = new int[5];
            char[] numberchar = new char[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter number " + i + " of 5:");
                int thisnumber = int.Parse(Console.ReadLine());

                if (numbers.Contains(thisnumber)) {
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sorry, this number has been used before\n");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Enter number " + i + " of 5:");
                        thisnumber = int.Parse(Console.ReadLine());
                        Console.Clear();

                    } while (numbers.Contains(thisnumber));
                }
                numbers[i] = thisnumber;

                Console.Clear();
            }

            Array.Sort(numbers);
            
            
            Console.Write("The list of sorted numbers is: ");
            for(var i = 0; i < 5; i++)
            {
                if (i==0)
                    Console.Write("{0}", numbers[i]);
                else
                    Console.Write(", {0}", numbers[i]);

            }
            Console.WriteLine("\n");
        }

        public static void threesmallest()
        {
            var numbers = new List<int>();
            Console.WriteLine(" Write a comma seperated list of 5 or more numbers:");
            string numberstring = Console.ReadLine();
            string[] splitme = numberstring.Split(',');

            if (splitme.Count() < 5)
            {
                do
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not 5 or more numbers seperated with commas. Try again:");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    numberstring = Console.ReadLine();
                    splitme = numberstring.Split(',');


                } while (splitme.Count() < 5);

            }
            
            foreach (var split in splitme)
            {

                int number = int.Parse(split);
                numbers.Add(number);
            }

            numbers.Sort();
            Console.Clear();

            Console.Write("Your 3 smallest numbers are: ");
            for(int i = 0; i < 3; i++)
            {
                if (i == 0)
                    Console.Write(numbers[i]);

                else
                    Console.Write(", " + numbers[i]);
            }
            Console.WriteLine("\n");

        }
    }

    public class workingWithText
    {

        public static void hyphenatedNumbers()
        {
            int[] numberarray = null;


            Console.WriteLine("Enter numbers seperated by hyphens:");
            var numbers = Console.ReadLine();
            var numbersplit = numbers.Split('-');
            numberarray = Array.ConvertAll(numbersplit, int.Parse);
            var size = ((numberarray.Max()) - (numberarray.Min()) + 1);

            if (size != numberarray.Count())
            {
                Console.WriteLine("Not Consecutive", size);

            }
            else
            {
                Console.WriteLine("Consecutive", size);

            }
        }

        public static void validTime()
        {
            Console.WriteLine("What time is your lunch (in 24 hour format)");
            var time = DateTime.Parse(Console.ReadLine());
            var timeshort = time.ToShortTimeString();
            Console.WriteLine("Lunch Time : {0}", timeshort);
        }
    }       
}
