// using .NET framework
using System;

namespace Treehouse.FitnessFrog 
{
    class Program 
    {
        // void is the return type
        // MAIN() is the method that C# looks for first. Must include
        public static void Main() 
        {
        double total = 0;
        bool keepGoing = true;

        while (keepGoing)
        {
            // prompt the user for minutes exercised
            Console.Write("Enter Minutes you exercised or type 'quit' to exit:");
                // System is namespace
                // Console is class/type
                // .Write is a method

            // get user input:
            string entry = Console.ReadLine();

            if (entry.ToLower() == "quit"){
                keepGoing = false;
            } else {
            
                try {
                    int minutes = int.Parse(entry)

                    if (minutes !>= 0) {
                        Console.WriteLine("not a valid time");
                        continue;

                    } else if (minutes <= 10) {
                        Console.WriteLine("Better than nothing.");

                    } else if (minutes <= 30) {
                        Console.WriteLine("way to go.");


                    } else if (minutes <= 60) {
                        Console.WriteLine("you must be a ninja warrior");

                    } else {
                        Console.WriteLine("now you're just showing off");
                    }
                }
                catch(FormatException) {
                    Console.Write("not valid input.")
                }


                // add minute to total
                total += minutes;

                // display the total
                Console.WriteLine("You've exercised " + total + " minutes.");

                // repeat prompt
            }}
        }
    }
}
