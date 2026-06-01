public class WritingAssignment : Assignment
{
    private string _title_PTE;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title_PTE = title;
    }

    public string GetWritingInformation()
    {
        return $"{base.GetSummary()}\n{_title_PTE}";
    }
}