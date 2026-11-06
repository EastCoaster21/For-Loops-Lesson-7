namespace For_Loops_Lesson_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a message, and I'll display it ten times."); 
            Console.WriteLine("Message: "); 
            String message = Console.ReadLine(); 
            for (int i = 1; i <= 10; i = i + 1) 
            { 
                Console.WriteLine(i + ". " + message); 
            }
            Console.WriteLine("PRESS ENTER TO CONTINUE");
            Console.ReadLine();


            int number;
            Console.Write("What do you want me to count to? ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i <= number; i += 1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            int start;
            int step;
            int end;
            Console.Write("Count from: ");
            start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Count to: ");
            end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Count by: ");
            step = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

        }
    }
}
