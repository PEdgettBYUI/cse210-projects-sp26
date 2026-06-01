public class Assignment
{
    private string _studentName_PTE;
    private string _topic_PTE;

    public Assignment(string studentName, string topic)
    {
        _studentName_PTE = studentName;
        _topic_PTE = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName_PTE} - {_topic_PTE}";
    }
}