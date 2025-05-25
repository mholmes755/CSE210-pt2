using System.Diagnostics.CodeAnalysis;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _verseEnd;



    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;

    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _verseEnd = endVerse;


    }

    public string GetDisplayText()
    {
        if (_verseEnd > 0 && _verseEnd != _startVerse)
        {
            return $"{_book} {_chapter}:{_startVerse}-{_verseEnd}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
    }
    }
