// Patrick works on this
class Reference
{
    private string _book_PTE;
    private int _chapter_PTE;
    private int? _singleVerse_PTE;  // nullable;
    private int? _startVerse_PTE;   // nullable; use with _endVerse_PTE
    private int? _endVerse_PTE;   // nullable; use with _startVerse_PTE

    // Constructors
    Reference(string book, int chapter, int verse)
    {
        _book_PTE = book;
        _chapter_PTE = chapter;
        _singleVerse_PTE = verse;
        _startVerse_PTE = null;
        _endVerse_PTE = null;
    }
    Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book_PTE = book;
        _chapter_PTE = chapter;
        _singleVerse_PTE = null;
        _startVerse_PTE = startVerse;
        _endVerse_PTE = endVerse;
    }
}