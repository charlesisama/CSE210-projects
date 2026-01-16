public class prompGenerator
{
    public List<string> _prompt = new List<string>();

    public string GetRandomPrompt()
    {
        Random newRandom = new Random();

        int index = newRandom.Next(_prompt.Count);

        string randomPrompt = _prompt[index];

        return randomPrompt;
    }

}