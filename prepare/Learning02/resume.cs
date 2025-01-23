public class Resume
{
    public string _personsname;

    public List<Job> _jobs = new List<Job>();

    public void Display_Resume()
    {
        Console.WriteLine($"Name: {_personsname}");
        Console.WriteLine("\nJobs:");
        
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }

}