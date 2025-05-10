using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        int percentage = int.Parse(Console.ReadLine());
        string letterGrade = "";
        string sign = "";
        // Determine the letter grade based on the percentage
        if (percentage >= 90)
        {
            letterGrade = "A";
        }
        else if (percentage >= 80)
        {
            letterGrade = "B";
        }
        else if (percentage >= 70)
        {
            letterGrade = "C";
        }
        else if (percentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        // Get the last digit of the percentage to determine the sign
        int lastDigit = percentage % 10;
        // Add "+" or "-" sign only for grades that are not A or F
        if (letterGrade != "F" && letterGrade != "A")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letterGrade == "A")
        {
            // Only allow A or A-, never A+
            if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        // Do not add signs to F grades (no F+ or F-)
        // Display pass/fail message based on the grade
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("You did not pass. Keep trying and don’t give up!");
        }
        // Display the final grade with sign (if any)
        Console.WriteLine($"Your final grade is: {letterGrade}{sign}");
    }
}
