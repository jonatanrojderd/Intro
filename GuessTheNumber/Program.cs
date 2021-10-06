using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Hitta på ett tal som användaren ska kunna gissa sig fram till.
             *
             *      - Skapa en random integer
             *      - User input - ska kunna jämföras
             *      - While loop - för att kunna gissa flera gånger
             *      - Visa upp en sträng som säger om användaren har gissat rätt eller fel.
             */
            Random random = new Random();
            int answer = random.Next(0, 10);
            //Console.WriteLine($"The answer is: {answer}");

            string userInput = Console.ReadLine();

            int userAnswer;
            while (!int.TryParse(userInput, out userAnswer))
            {
                Console.WriteLine("Wrong type of input");
                userInput = Console.ReadLine();
            }

            while (userAnswer != answer)
            {
                if (int.TryParse(userInput, out userAnswer))
                {
                    if (userAnswer < answer)
                    {
                        Console.WriteLine("Too low");
                    }
                    else if (userAnswer > answer)
                    {
                        Console.WriteLine("Too high");
                    }
                }

                userInput = Console.ReadLine();
            }

            // if (userAnswer == answer)
            // {
            Console.WriteLine("You nailed it!");
            //             
            //     // Exit the while loop
            //     break;
            // }
        }
    }
}