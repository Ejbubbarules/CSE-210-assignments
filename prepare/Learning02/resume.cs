class Resume
{
    public string _name;
    public List<job> _jobs;
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");

        foreach(Job job in _jobs)
        {
            // Console.WriteLine(job);
            job.displayJob();
        }
    }
}