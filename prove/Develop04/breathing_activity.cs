public class BreathingActivity : Activity
{

    public BreathingActivity()
        : base("Breathing", "This activity will help you relax by breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    
    }
    
    public void DoActivity()
    {
        DisplayIntro();
        ShowGetReady();

        Console.WriteLine("Follow the breathing pattern:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\nBreathe in...");
            ShowCountdown(4);
            Console.WriteLine("Breathe out...");
            ShowCountdown(6);
        }

        DisplayWellDone();
        Console.Clear();
    }
}