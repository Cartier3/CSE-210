using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        
        // Creates instances of the DateTime class while then taking only the date variable from it to add to the Activity class constructors.
        DateTime date1 = new DateTime(2025, 02, 22);
        var _date1 = DateOnly.FromDateTime(date1);

        DateTime date2 = new DateTime(2025, 03, 14);
        var _date2 = DateOnly.FromDateTime(date2);

        DateTime date3 = new DateTime(2025, 12, 25);
        var _date3 = DateOnly.FromDateTime(date3);

        // One instance of the Running class, statbiking class, and the swimming class. 
        Running running1 = new Running(30, _date1, 3);

        StationaryBiking statBike1 = new StationaryBiking(60, _date2, 6);

        Swimming swim1 = new Swimming(90, _date3, 10);

        // Adds each instance of the class to the 'activities' list above. 
        activities.Add(running1);

        activities.Add(statBike1);

        activities.Add(swim1);

        // For each activity in the 'activities' list, it calls the GetSummary() method on each class instance.  
        foreach (Activity a in activities)
        {
            a.GetSummary();
        }

    }
}