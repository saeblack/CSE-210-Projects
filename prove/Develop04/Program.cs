using System;

class _Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter duration in seconds: ");
                int duration = int.Parse(Console.ReadLine());
                _Activity activity = new _BreathingActivity(duration);
                activity._Start();
            }
            else if (choice == "2")
            {
                Console.Write("Enter duration in seconds: ");
                int duration = int.Parse(Console.ReadLine());
                _Activity activity = new _ReflectionActivity(duration);
                activity._Start();
            }
            else if (choice == "3")
            {
                Console.Write("Enter duration in seconds: ");
                int duration = int.Parse(Console.ReadLine());
                _Activity activity = new _ListingActivity(duration);
                activity._Start();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Exiting...");
                break;
            }
               else
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
            }

            Console.WriteLine();
        }
    }
}