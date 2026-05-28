namespace Develop03;

public class Scripture
{
    private Reference _jlbReference;
    private List<Word> _jlbWordsList;
    private Random _jlbRandomGenerator;

    public Scripture(string jlbBook, int jlbChapter, int jlbVerse, string jlbScriptureText)
    {
        _jlbReference = new Reference(jlbBook, jlbChapter, jlbVerse);
        _jlbWordsList = new List<Word>();
        _jlbRandomGenerator = new Random();

        CreateWordList(jlbScriptureText);
    }

    public Scripture(string jlbBook, int jlbChapter, int jlbStartVerse, int jlbEndVerse, string jlbScriptureText)
    {
        _jlbReference = new Reference(jlbBook, jlbChapter, jlbStartVerse, jlbEndVerse);
        _jlbWordsList = new List<Word>();
        _jlbRandomGenerator = new Random();

        CreateWordList(jlbScriptureText);
    }

    private void CreateWordList(string jlbScriptureText)
    {
        string[] jlbWordsArray = jlbScriptureText.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        foreach (string jlbWordText in jlbWordsArray)
        {
            Word jlbNewWord = new Word(jlbWordText);
            _jlbWordsList.Add(jlbNewWord);
        }
    }

    public void DisplayScripture()
    {
        _jlbReference.ShowReference();
        Console.WriteLine();

        foreach (Word jlbWord in _jlbWordsList)
        {
            jlbWord.ShowWord();
            Console.Write(" ");
        }

        Console.WriteLine();
    }

    public bool HideSomeWords()
    {
        int jlbWordsToHide = 5;
        int jlbUnhiddenWordsCount = _jlbWordsList.Count - CountHiddenWords();

        if (jlbUnhiddenWordsCount == 0)
        {
            return true;
        }

        if (jlbUnhiddenWordsCount < jlbWordsToHide)
        {
            jlbWordsToHide = jlbUnhiddenWordsCount;
        }

        int jlbHiddenThisTurn = 0;

        while (jlbHiddenThisTurn < jlbWordsToHide)
        {
            int jlbRandomIndex = _jlbRandomGenerator.Next(_jlbWordsList.Count);
            Word jlbRandomWord = _jlbWordsList[jlbRandomIndex];

            if (!jlbRandomWord.GetHidden())
            {
                jlbRandomWord.Hide();
                jlbHiddenThisTurn++;
            }
        }

        return CountHiddenWords() == _jlbWordsList.Count;
    }

    public int CountHiddenWords()
    {
        int jlbHiddenCount = 0;

        foreach (Word jlbWord in _jlbWordsList)
        {
            if (jlbWord.GetHidden())
            {
                jlbHiddenCount++;
            }
        }

        return jlbHiddenCount;
    }

    public bool IsCompletelyHidden()
    {
        return CountHiddenWords() == _jlbWordsList.Count;
    }
}