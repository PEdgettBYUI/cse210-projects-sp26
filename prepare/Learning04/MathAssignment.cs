public class MathAssignment : Assignment
{
    private string _textbookSection_PTE;
    private string _problems;


    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection_PTE = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{base.GetSummary()}\n{_textbookSection_PTE} {_problems}";
    }

}