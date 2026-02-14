using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> myActivities = new List<Activity>();

        myActivities.Add(new Running("03 Nov 2022", 30, 5.0));
        myActivities.Add(new Cycling("04 Nov 2022", 45, 20.0));
        myActivities.Add(new Swimming("05 Nov 2022", 40, 30));

        foreach (Activity activity in myActivities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}