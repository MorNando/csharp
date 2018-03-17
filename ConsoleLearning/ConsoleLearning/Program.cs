using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post("this is the title", "this is the descriptio");

            ConsoleKeyInfo ans;
            do
            {
                Console.Clear();
                Console.WriteLine("Your post information is:");
                Console.WriteLine("Post Title: " + post.Title);
                Console.WriteLine("Post Description: " + post.Description);
                Console.WriteLine("Time of Post: " + post.PostTime.ToShortDateString() + " " + post.PostTime.ToShortTimeString());
                Console.WriteLine("total votes: " + post.Votes);

                Console.WriteLine(@"
what would you like to do?
u - upvote
d - downvote
q - quit");
                ans = Console.ReadKey();
                if (ans.KeyChar == 'u')
                {
                    post.Upvote();
                }

                else if (ans.KeyChar == 'd')
                {
                    post.DownVote();
                }

                else if (ans.KeyChar == 'q')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("that was not a valid keypress. No Votes were registered");
                    Console.WriteLine("Press any key to start again...");
                    Console.ReadKey();
                }
                
            }while (ans.KeyChar != 'q') ;
        }
    }
}
