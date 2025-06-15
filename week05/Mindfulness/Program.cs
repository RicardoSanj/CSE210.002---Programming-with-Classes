// EXTRA: This program exceeds basic requirements by modularizing each activity into its own class, adding spinner animations for pausing,
// and handling invalid input gracefully. It also uses countdown and progress indicators to enhance user experience.

using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            Activity activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectionActivity(),
                "3" => new ListingActivity(),
                "4" => null,
                _ => null
            };

            if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else if (activity != null)
            {
                activity.PerformActivity();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select again.");
                Thread.Sleep(2000);
            }
        }
    }
}
