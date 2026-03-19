class Program
{
    static void Main()
    {
        SessionTracker tracker = new SessionTracker();
        tracker.Load();

        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program\n");
            Console.WriteLine($"Total sessions completed: {tracker.GetTotalSessions()}\n");

            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                new BreathingActivity().Run();
                tracker.AddSession();
            }
            else if (choice == "2")
            {
                new ReflectionActivity().Run();
                tracker.AddSession();
            }
            else if (choice == "3")
            {
                new ListingActivity().Run();
                tracker.AddSession();
            }
        }

        tracker.Save();
    }
}