using System.Reflection;
using System.Security.Cryptography.X509Certificates;

public class Activity
{
    protected string _name;

    protected string _description;

    protected int _duration;

    List<Activity> activities = new List<Activity>();

    private List<string> animationFrames = new List<string>();
    

    public Activity(string uName, string uDescription)
    {
        _name = uName;
        _description = uDescription;
        _duration = PromptDuration();

    }

    public void DisplayIntro()
    {
        Console.WriteLine($"\nThis is the {_name} Activity.");
        Console.WriteLine($"{_description}");
    }

    public int PromptDuration()
    {
        Console.Write("How long, in seconds, would you like your session: ");
        string uInput = Console.ReadLine();
        int convUInput2 = int.Parse(uInput);

        return convUInput2;
    }

    public void ShowGetReady()
    {
        Console.WriteLine("\nGet Ready!");
        CallAnimation(10);
    }
    
    public void DisplayWellDone()
    {
        Console.WriteLine("\nWell Done!");
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity!");
        CallAnimation(7);
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");  // Prints the number
            Thread.Sleep(1000);      // Waits 1 second
            Console.Write("\r");     // Moves the cursor back to the beginning of the line
        }

        Console.WriteLine(" ");
        Console.WriteLine("\r");
    }

    public void CallAnimation(int tDuration)
    {
        animationFrames.Add("|");
        animationFrames.Add("/");
        animationFrames.Add("-");
        animationFrames.Add("\\");
        animationFrames.Add("|");
        animationFrames.Add("/");
        animationFrames.Add("-");
        animationFrames.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(tDuration);
        int i = 0;
        
        while (DateTime.Now < endTime)
        {
            
            Console.Write("\b" + animationFrames[i]);
            Thread.Sleep(200);

            i++;

            if (i >= animationFrames.Count)
            {
                i = 0;
            }
        }

        Console.Clear();
    }

    



}