public class Entry
{
    public string _prompt;
    public string _response;

    public string _currentTime;

    public void DisplayEntry() 
    {
        Console.WriteLine($"{_currentTime} | {_prompt} | {_response}");
        
    }
}