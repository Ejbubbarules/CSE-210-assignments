class job
{
    public string _companyname;

    public string _jobtitle;
    public int _startyear;

    public int _endyear;


    public void DisplayJob()
    {
        Console.WriteLine($"Name: {_companyname}, Title {_jobtitle}, Started: {_startyear}, Ended {_endyear}");
    }
}