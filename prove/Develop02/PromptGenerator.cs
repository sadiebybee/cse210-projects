
public class PromptGenerator
{
    public List<string> Prompts {get; set;}

    public PromptGenerator() {
        Prompts = new List<string>
        {
            "What are you most grateful for today?",
            "What three things made you happy this week?",
            "What is one thing you learned today?",
            "How did you see the hand of the Lord in your life today?",
            "Write about a positive interaction you had with someone today:",
            "If I had one thing I could do over today, what would it be?",
            "What would I tell my younger self?",
            "What's something small that brought me joy today?",
            "If I could do anything without fear, what would it be?"
        };
    }

    public string GenerateRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(Prompts.Count);
        return Prompts[index];
    }
}