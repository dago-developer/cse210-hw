using System;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new RunningActivity(DateTime.Now, 30, 3.0),
            new CyclingActivity(DateTime.Now, 45, 12.0),
            new SwimmingActivity(DateTime.Now, 25, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
