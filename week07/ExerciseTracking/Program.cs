using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        List<Activity> activities = new List<Activity>();

        RunningActivity running = new RunningActivity("14 Feb 2026", 30, 3);

        CyclingActivity cycling = new CyclingActivity("15 Feb 2026", 30, 6);

        SwimmingActivity swimming = new SwimmingActivity("16 Feb 2026", 30, 10);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        Console.WriteLine("===========================================");

        foreach (Activity activity in activities)
        {
            string summary = activity.GetSummary();
            Console.WriteLine(summary);
        }

        Console.WriteLine("===========================================");
    }
}