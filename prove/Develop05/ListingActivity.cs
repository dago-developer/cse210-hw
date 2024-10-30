using System;
public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity helps you list the good things in your life.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();
        ShowCountDown(5); 

        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        ShowCountDown(5); 

        Console.WriteLine("Start listing items. Press Enter between each item. Type 'done' when finished:");

        List<string> items = new List<string>();
        while (true)
        {
            string item = Console.ReadLine();
            if (item.ToLower() == "done")
                break;
            items.Add(item);
        }

        Console.WriteLine($"You listed {items.Count} items.");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}
