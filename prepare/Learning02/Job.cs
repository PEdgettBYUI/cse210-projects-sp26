public class Job
{
    public string _jobTitle_PTE;
    public string _company_PTE;
    public int _startYear_PTE;
    public int _endYear_PTE;

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle_PTE} ({_company_PTE}) {_startYear_PTE}-{_endYear_PTE}");
    }
}