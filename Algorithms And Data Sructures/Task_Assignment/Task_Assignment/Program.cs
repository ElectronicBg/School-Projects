using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    struct Activity
    {
        public int Start;
        public int End;
        public int Index;
    }

    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        // Input activities and their time intervals
        Console.WriteLine("Enter the number of activities:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Activity {i + 1}:");
            Console.Write("Start: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("End: ");
            int end = int.Parse(Console.ReadLine());

            activities.Add(new Activity { Start = start, End = end, Index = i + 1 });
        }

        // Sort activities by end time
        activities = activities.OrderBy(a => a.End).ToList();

        // Find the maximum number of non-conflicting activities and print them
        List<Activity> selectedActivities = FindMaxActivities(activities);
        Console.WriteLine("Sequence of activities:");

        foreach (var activity in selectedActivities)
        {
            Console.WriteLine($"Activity {activity.Index}: Start: {activity.Start}, End: {activity.End}");
        }
    }

    static List<Activity> FindMaxActivities(List<Activity> activities)
    {
        int n = activities.Count;
        List<Activity> selectedActivities = new List<Activity>();
        selectedActivities.Add(activities[0]);
        int currentActivity = 0;

        for (int i = 1; i < n; i++)
        {
            if (activities[i].Start >= activities[currentActivity].End)
            {
                selectedActivities.Add(activities[i]);
                currentActivity = i;
            }
        }

        return selectedActivities;
    }
}
