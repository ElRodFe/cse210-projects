public class Prompt
{
    public List<string> _prompts = new List<string>();

    public void GetRandomPrompt()
    {
        Random rnd = new Random();
        int randomNumber = rnd.Next(0,4);

        Console.Write(_prompts[randomNumber]);
        string response = Console.ReadLine();
    }
}