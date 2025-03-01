public class ListingActivity : Activity
{
    private List<string> items = new List<string>();

    private List<string> prompts = new List<string>()
    {
        "When have you felt the Holy Spirit the most this last month?",
        "When were the most recent moments where you served someone else?",
        "When were the last couple of times that you talked to a friend?",
        "What were some of your favorite meals that you ate this last week?",
        "What fun activities have you been a part of this last month?"
    };
    
    public ListingActivity()
        : base("Listing", "This activity will help you list as many responses possible that you can type to an uplifting prompt that is given.")
    {
        
    }
    
    public void DoActivity()
    {
        DisplayIntro();
        ShowGetReady();

        Random random = new Random();
        string selectedPrompt = prompts[random.Next(prompts.Count)];

        Console.WriteLine("Please list as many responses you can to the following prompt: ");
        Console.WriteLine($"\n--{selectedPrompt}--");
        Console.WriteLine($"\nYou may begin in:"); 
        ShowCountdown(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        
        List<string> responses = new List<string>();

        Console.WriteLine("Now, begin typing your responses:");

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)  // Checks if a key is pressed.
            {
                string userInput = Console.ReadLine();  // Captures the user's response.
                if (!string.IsNullOrEmpty(userInput))  // Avoids adding empty responses to the 'responses' list.
                {
                    responses.Add(userInput);  // Adds the user's typed response to the 'responses' list.
                }
            }
        }

        Console.WriteLine("\nThat's time!");
        Console.WriteLine($"Amazing work! You wrote {responses.Count} responses to the prompt!");

        DisplayWellDone();
    }
}