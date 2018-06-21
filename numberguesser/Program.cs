using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberguesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Scores score = new Scores();
            GetAppinfo();

            GetUserinfo();

            while (true)
            {
                Random random;
                random = new Random();
                int correctNumber = random.Next(10);
                Console.WriteLine("Guess the number");
                string input = Console.ReadLine();

                int userinput = int.Parse(input);

                while (userinput != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong number.. Please try again");
                    Console.ResetColor();

                    input = Console.ReadLine();
                    userinput = int.Parse(input);

                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Great! You are correct");
                Console.ResetColor();

                Console.WriteLine("Replay? [y or N]");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;

                }
                else
                {
                    return;
                }
                Console.ReadKey();
            }
        }

        private static void GetUserinfo()
        {
            Console.WriteLine("Type your name");
            string username = Console.ReadLine();
            Console.WriteLine("Welcome" + (username));
            Console.WriteLine(Environment.NewLine);
        }
        static void GetAppinfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("This is a Number-guessing game");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Ebuka");
            Console.WriteLine(Environment.NewLine);
            Console.ResetColor();

        }
    }
}
