public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

    public Reference(string book, int chapter, int verseStart, int verseEnd = -1)
    {
        _book = book;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    public string GetDisplayText()
    {
        if (_verseEnd == -1)
        {
            return $"{_book} {_chapter}:{_verseStart}";
        }
        return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
    }
}