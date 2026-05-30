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

        // NOTE: Pull this out and replace it with a function call
        //  to better satisfy design requirements
        if (jlbUnhiddenWordsCount == 0)
        {
            return true;
        }

        // If there are less visible words than the amount that 
        //  need to be hidden, only hide what needs to be hidden
        if (jlbUnhiddenWordsCount < jlbWordsToHide)
        {
            jlbWordsToHide = jlbUnhiddenWordsCount;
        }

        int jlbHiddenThisTurn = 0;

        // While there are still words to hide, randomly find a word
        //  that is not hidden and toggle hide flag, then iterate the counter
        while (jlbHiddenThisTurn < jlbWordsToHide)
        {
            int jlbRandomIndex = _jlbRandomGenerator.Next(_jlbWordsList.Count);
            Word jlbRandomWord = _jlbWordsList[jlbRandomIndex];

            // Check if the word is hidden
            if (!jlbRandomWord.GetHidden())
            {
                jlbRandomWord.Hide();
                jlbHiddenThisTurn++;
            }
        }

        return false;
        // return CountHiddenWords() == _jlbWordsList.Count;
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