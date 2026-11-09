using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace For_Loops_Lesson_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lesson stuff
            //Console.WriteLine("Type a message, and I'll display it ten times."); 
            //Console.WriteLine("Message: "); 
            //String message = Console.ReadLine(); 
            //for (int i = 1; i <= 10; i = i + 1) 
            //{ 
            //    Console.WriteLine(i + ". " + message); 
            //}
            //Console.WriteLine("PRESS ENTER TO CONTINUE");
            //Console.ReadLine();


            //int number;
            //Console.Write("What do you want me to count to? ");
            //number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();

            //for (int i = 0; i <= number; i += 1)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();

            //int start;
            //int step;
            //int end;
            //Console.Write("Count from: ");
            //start = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();
            //Console.Write("Count to: ");
            //end = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();
            //Console.Write("Count by: ");
            //step = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();

            //Menu ripped from my topic 5
            Console.WriteLine("Please choose your experience:");
            Console.WriteLine();
            Console.WriteLine("1-Countdown to blastoff");
            Console.WriteLine("2-X and Y");
            Console.WriteLine("3-For Loop Fun");
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (choice == 1)
            {
                BlastOff();
            }
            else if (choice == 2)
            {
                XAndY();
            }
            else if (choice == 3)
            {
                ForLoopFun();
            }
        }

            public static void BlastOff()
            {
                for (int i = 10; i >= 0; i--)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("Blast Off!");
            }   

            public static void XAndY()
            {
                Console.WriteLine("X\tY");
                Console.WriteLine("----------------");

                for (int i = -10; i <= 10; i += 2)
                {
                    int y = i * i;

                    Console.WriteLine(i + "\t" + y);
                }
            }

            public static void ForLoopFun()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            int times = 10;

            if (name.ToUpper() == "ALDWORTH")
            {
                times = 5;
            }

            for (int i = 1; i <= times; i++)
            {
                Console.WriteLine(name);
            }
        }
    }
}

