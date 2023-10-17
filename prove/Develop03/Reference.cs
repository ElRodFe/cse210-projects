public class Reference
{
    private string _book;
    private int _chapter;
    private int _vers;

    public Reference(string book, int chapter, int versicle)
    {
        _book = book;
        _chapter = chapter;
        _vers = versicle;
    }

    public void DisplayReference()
    {
        Console.WriteLine($"{_book} {_chapter}:{_vers}.");
    }
}