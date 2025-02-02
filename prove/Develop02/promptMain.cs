public class PromptMain
{
    private List<string> _prompts = new List<string>
    {
        "What was the best part of your day?",
        "Who was the most interesting person you talked to all day? What did you talk about?",
        "Did you learn anything new today? If so, what was it?",
        "Did you do something nice for anyone today? If so, describe it a little.",
        "What was your best accomplishment today? How did it make you feel?",
        "Do you have any new goals you want to write about? If so, what are they and how will you achieve them?",
        "What was the hardest part of your day? Explain why and what could've made it better."
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        return _prompts[randomIndex];
    }


}