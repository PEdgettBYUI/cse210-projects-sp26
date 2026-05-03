public class Resume
{
    public string _name_PTE;

    public List<Job> _jobs_PTE = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name_PTE}");
        Console.WriteLine("Jobs: ");

        foreach(Job item in _jobs_PTE)
        {
            item.DisplayJobDetails();
        }
    }

}