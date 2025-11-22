using System.Security.Cryptography;

public class Reference
{
    private String _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int startVerse )
    {
       _book = book;
       _chapter = chapter;
       _startVerse = startVerse;
       _endVerse = startVerse;

    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    } 
    public string GetBook()
    {
        return _book;
    }
    public int GetChapter()
    {
        return _chapter;
    }
    public int GetVerseStart()
    {
        return _startVerse;
    }
    public int GetVerseEnd()
    {
        return _endVerse;
    }
}