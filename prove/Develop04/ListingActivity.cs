class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who do you appreciate?",
        "What are your strengths?",
        "Who have you helped recently?"
    };

    public ListingActivity()
        : base("Listing Activity",
        "List as many positive things as you can.") { }

    public void Run()
    {
        StartMessage();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine($"\n{prompt}");
        Console.Write("You may begin in: ");
        ShowCountdown(5);

        int count = 0;
        DateTime end = DateTime.Now.AddSeconds(_duration);

        Console.WriteLine("\nStart listing:");

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");

        EndMessage();
    }
}