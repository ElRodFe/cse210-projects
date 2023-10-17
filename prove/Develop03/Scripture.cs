public class Scripture
{
    private string _passage;
    private List<int> _hiddenWords;
    private List<string> _words;

    public Scripture(string passage)
    {
        _passage = passage;
        _hiddenWords =  new List<int>();
        _words = _passage.Split(" ").ToList();
    }

    public void DisplayScripture()
    {
        Console.WriteLine(_passage);
    }

    public void HideWord()
    {
        if (_hiddenWords.Count >= _words.Count) {
            Environment.Exit(0);
        }

        Random rnd = new Random();
        int index; 
        do {
            index = rnd.Next(0, _words.Count());
        } while (_hiddenWords.Contains(index));

        _hiddenWords.Add(index);
        _words[index] = "_";
        _passage = string.Join(" ", _words);

        Console.WriteLine(_passage);
    }
}