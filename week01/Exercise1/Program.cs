using System;

class Program
{
    static void Main(string[] args)
    {

            // Ask the user for their first name
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();
            // Ask the user for their last name
            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();
            // Display the formatted full name in the specific format
            // Example: "Your name is Burton, Scott Burton."
            Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
}
