public class Journal
{
    public List<string> _entries = new List<string>();
    public string _currentTime = DateTime.Now.ToString("dddd, dd MMMM yyyy");

    public void NewEntry()
    {
        Prompt newEntry = new Prompt();
        newEntry.GetRandomPrompt();
    }

    public void DisplayEntries()
    {
        foreach (string e in _entries)
        {
            Console.WriteLine(e);
        }
    }
}