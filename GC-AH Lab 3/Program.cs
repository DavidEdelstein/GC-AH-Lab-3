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
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    EvenAndOddNumbers(name, number);

                    while (true)
                    {
                        Console.WriteLine("Enter 1 to continue or 2 to stop");
                        var answer = Console.ReadLine();

                        if (answer == "1")
                        {
                            break;
                        }
                        else if (answer == "2")
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("AGAIN!! 1 to continue and 2 to exit!! Pay attention!! THANK YOU!!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("We only take numbers punk!(press any key to start again)");
                }
                //Console.ReadKey();
            }
           
        }

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
                Console.WriteLine($"That`s waaaay to high {name}!!!, Please only input numbers 1 - 100:");
            }
        }
    }
    
}
