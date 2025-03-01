public class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>()
    {
        "Think of a time where you accomplished something difficult.",
        "Reflect on a moment where you took time to help someone else.",
        "Recall a moment where you experienced failure.",
        "Think of one experience that you are truly grateful for.",
        "When was the last time that you felt completely at peace within?"
    };

    private Dictionary<string, List<string>> followUpQuestions = new Dictionary<string, List<string>>
    {
        {"Think of a time where you accomplished something difficult.",
        new List<string>
        {
            "How did you feel afterwords?",
            "What made this experience special to you?",
            "What did you learn from this experience?"
        }
        },
        
        { "Reflect on a moment where you took time to help someone else.", 
        new List<string>
        {
            "How did you feel after helping them?",
            "What did you take away from this experience?",
            "What did you learn from this experience?",
            "What made this experience special for you?"
        }
        },

        {"Recall a moment where you experienced failure.",
        new List<string>
        {
            "What did you learn from this moment?",
            "What can you do to make this experience meaningful to you?",
            "Is there anything you can do to prevent a failure like this from happening again?"
        }
        },

        {"Think of one experience that you are truly grateful for.",
        new List<string>
        {
            "Why are you grateful for this experience?",
            "What made this experience unique to yourself?",
            "How does this experience strengthen you today?"
        }
        },

        {"When was the last time that you felt completely at peace within?",
        new List<string>
        {
            "How did you feel in this moment?",
            "What was your favorite part about this experience?",
            "How could you create another experience like this for yourself in the future?"
        }
        }
    
    };


    public ReflectionActivity()
        : base("Reflecting", "This activity will help you reflect on positive experiences and the personal growth that you have experienced throughout your life.")
    {
        
    }

    public void DoActivity()
    {
        DisplayIntro();
        
        ShowGetReady();

        Random random = new Random();
        string selectedPrompt = prompts[random.Next(prompts.Count)];

        Console.WriteLine("Please reflect on the following prompt:");
        Console.WriteLine($"\n--{selectedPrompt}--");
        Console.Write("\nPress 'ENTER' when you are ready to continue:");
        Console.ReadLine();

        List<string> selectedFollowUpQuestions = followUpQuestions[selectedPrompt];
    
        DateTime endTime = DateTime.Now.AddSeconds(_duration);  // Runs the activity for _duration in seconds.

        Console.Clear();
        Console.WriteLine("Now reflect on the following questions about your experience:");

        List<int> askedQuestions = new List<int>();

        while (DateTime.Now < endTime)
        {
            int randomIndex;
            
            do
            {
                randomIndex = random.Next(selectedFollowUpQuestions.Count);
            } while (askedQuestions.Contains(randomIndex));  // If a question is already selected, it will choose another.

            // Adds the current question's index to the list of asked questions.
            askedQuestions.Add(randomIndex);
            
            // Picks a random follow-up question from the selected prompt's questions in the Dictionary.
            Console.WriteLine($"\n'{selectedFollowUpQuestions[randomIndex]}'");
            
            Thread.Sleep(10000);  // Makes the system wait for 10 seconds before showing another question

            if (askedQuestions.Count == selectedFollowUpQuestions.Count)
            {
                break;
            }
        }

        DisplayWellDone();

    }   
}