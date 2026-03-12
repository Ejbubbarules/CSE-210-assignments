using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Scripture Memorizer");
        Console.WriteLine("-------------------");
        Console.WriteLine("Choose a scripture:");
        Console.WriteLine("1. John 3:16");
        Console.WriteLine("2. Mosiah 2:41");
        Console.WriteLine("3. 3 Nephi 11:11");
        Console.Write("Enter your choice: ");

        string choice = Console.ReadLine();

        Scripture scripture;

        if (choice == "1")
        {
            Reference reference = new Reference("John", 3, 16);

            scripture = new Scripture(reference,
            "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life");
        }
        else if (choice == "2")
        {
            Reference reference = new Reference("Mosiah", 2, 41);

            scripture = new Scripture(reference,
            "And moreover I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God For behold they are blessed in all things both temporal and spiritual and if they hold out faithful to the end they are received into heaven that thereby they may dwell with God in a state of never ending happiness O remember remember that these things are true for the Lord God hath spoken it");
        }
        else
        {
            Reference reference = new Reference("3 Nephi", 11, 11);

            scripture = new Scripture(reference,
            "And behold I am the light and the life of the world and I have drunk out of that bitter cup which the Father hath given me and have glorified the Father in taking upon me the sins of the world in the which I have suffered the will of the Father in all things from the beginning");
        }

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress ENTER to hide words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words hidden. Program complete.");
    }
}