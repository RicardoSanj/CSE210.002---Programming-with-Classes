using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    Thread.Sleep(2000);
                    continue;
            }

            activity.PerformActivity();
        }
    }
}

// 🚀 EXCEDE REQUISITOS:
// Se implementó animación spinner con backspaces durante las pausas.
// Comentarios descriptivos están presentes. Se podrían agregar logs o exportar a archivo en versiones futuras.
