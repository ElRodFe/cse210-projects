using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public string _currentTime = DateTime.Now.ToString("dddd, dd MMMM yyyy");

    public void NewEntry()
    {
        Entry theEntry = new Entry();
        Prompt thePrompt = new Prompt();

        theEntry._prompt = thePrompt.GetRandomPrompt();
        
        Console.WriteLine(theEntry._prompt);
        theEntry._response = Console.ReadLine();

        theEntry._currentTime = _currentTime;

        _entries.Add(theEntry);

        
        
    }

    public void DisplayEntries()
    {
        foreach (Entry e in _entries)
        {
            e.DisplayEntry();
        }
    }

    public void SaveFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._currentTime} | {e._prompt} | {e._response}");
            }
        }
    }

    public void LoadFile(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string e in lines)
        {
            Console.WriteLine(e);
        }
    }
}