using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2025, 10, 14), 30, 4.8),
            new Cycling(new DateTime(2025, 10, 14), 45, 20.0),
            new Swimming(new DateTime(2025, 10, 14), 30, 40)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
