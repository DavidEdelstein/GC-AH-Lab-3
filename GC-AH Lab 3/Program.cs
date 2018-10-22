using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_AH_Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What`s your name dude?");
            var name = Console.ReadLine();

            while (true)
            {
                Console.Write($"{name} Please enter a number from 1 to 100...PLEASE!! (sob) I BEG YOU!!:");
                // James - I see you are getting used to validation with TryParse(), good job!
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    // James - just so you know, negative numbers are not handled in this code.
                    EvenAndOddNumbers(name, number);

                    while (true)
                    {
                        // James - This is a neat way to see if you want to stop the program or not
                        Console.WriteLine("Enter 1 to continue or 2 to stop");
                        var answer = Console.ReadLine();

                        if (answer == "1")
                        {
                            break;
                        }
                        else if (answer == "2")
                        {
                            // James - I like that you used a return here, just as long as you know what this is doing.
                            return;
                        }
                        else
                        {
                            // James - lol... nice
                            Console.WriteLine("AGAIN!! 1 to continue and 2 to exit!! Pay attention!! THANK YOU!!");
                        }
                    }
                }
                else
                {   // James - lol
                    Console.WriteLine("We only take numbers punk!(press any key to start again)");
                }
                //Console.ReadKey();
            }
           
        }

        // James - I love that you put the "business logic" inside of this method! this help organizes your code, good job
        private static void EvenAndOddNumbers(string name, int number)
        {
            if (number % 2 == 0 && number < 25)
            {
                Console.WriteLine($"{name} , The number that you have entered - {number} is EVEN and LESS than 25.");
            }
            else if (number % 2 == 0 && number > 25 && number < 60)
            {
                Console.WriteLine($"EVEN number {name}!!! HECK YEAH!!!");
            }
            else if (number % 2 == 0 && number > 60 && number < 101)
            {
                Console.WriteLine($"Would you believe it {name}? This here {number} is EVEN!!");
            }
            else if (number % 1 == 0 && number < 100)
            {
                Console.WriteLine($"{number} is ODD {name}.");
            }
            else
            {
                // James - I see what you are doing here... and I see from a design choice that you want the user
                // to decide if they want to run the whole program or not.  I like this decision to be honest
                Console.WriteLine($"That`s waaaay to high {name}!!!, Please only input numbers 1 - 100:");
            }
        }
    }
    
}
