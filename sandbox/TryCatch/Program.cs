class Program
{
    public static int GetAge()
    {
        int age = 0;
        bool done = false;

        while (!done)
        {
            try
            {
                Console.WriteLine("Please enter your age: ");
                age = int.Parse(Console.ReadLine());
                if (age>= 0 && age <= 125)
                {
                    done = true;
                }
                    else
                {
                    Console.WriteLine("Please enter a valid age");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please enter a valid age");
            }
        }
        return age;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine($"Your age is : {GetAge()}");
    }
}