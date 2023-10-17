public class Scripture
{
    private string _passage;
    private List<string> _words;
    private Word _wordsList;

    public Scripture(string passage, Word wordsList)
    {
        _passage = passage;
        _words = _passage.Split(" ").ToList();
        _wordsList = wordsList;  
    }

    public void DisplayScripture()
    {
        Console.WriteLine(_passage);
    }

    public void HideWord()
    {
        if (_wordsList.GetList().Count >= _words.Count) {
            Environment.Exit(0);
        }

        Random rnd = new Random();
        int index; 
        do {
            index = rnd.Next(0, _words.Count());
        } while (_wordsList.GetList().Contains(index));

        _wordsList.SetToList(index);
        _words[index] = "_";
        _passage = string.Join(" ", _words);

        Console.WriteLine(_passage);
    }
}