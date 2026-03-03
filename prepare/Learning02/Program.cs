using System;

class Program
{
    static void Main(string[] args)
    {
        job myFirstJob = new job();

        myFirstJob._companyname = "Chipotle";
        myFirstJob._jobtitle = "Line Worker";
        myFirstJob._startyear = 2016;
        myFirstJob._endyear = 2017;

        myFirstJob.DisplayJob();

        job mySecondJob = new job();

        mySecondJob._companyname = "Walmart";
        mySecondJob._jobtitle = "Meat and Produce Associate";
        mySecondJob._startyear = 2025;
        mySecondJob._endyear = 2025;

        mySecondJob.DisplayJob();

        Resume myResume = new Resume();
        myResume._name = "Ethan Finlay";
        myResume._jobs = new List<job>();
        myResume._jobs.Add(myFirstJob);
        myResume._jobs.Add(mySecondJob);

        myResume.DisplayResume();
    }
}