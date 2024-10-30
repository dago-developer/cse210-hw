using System;

public class CountingActivity : Activity
{
    public CountingActivity() : base("Counting Activity", "This activity guides you to count positive things in your life.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();
        ShowCountDown(5); 

        Console.WriteLine("Start counting how many positive things you can think of. Press Enter after each item. Type 'done' when finished:");

        int count = 0;
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done")
                break;

            count++;
            Console.WriteLine($"Counted: {input}. Total count: {count}");
        }

        Console.WriteLine($"You counted {count} positive things.");
        DisplayEndingMessage();
    }
}
