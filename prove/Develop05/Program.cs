using System;

class Program
{
    static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nMindfulness Activities Menu");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Counting Activity");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an activity by entering the number: ");
            string choice = Console.ReadLine();

            Activity activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectingActivity(),
                "3" => new ListingActivity(),
                "4" => new CountingActivity(),
                "5" => null,
                _ => throw new InvalidOperationException("Invalid choice.")
            };

            if (activity != null)
            {
                activity.Run();
            }
            else
            {
                exit = true;
                Console.WriteLine("Exiting. Thank you for practicing mindfulness!");
            }
        }
    }
}
