using System;
using System.Text;

namespace Hangman
{
    class Program
    {
        static void Main()
        {
            /* TODO: What do we need?
             * User Input
             * List of Words / Answers
             *  -   A way to randomly select a Word
             * Compare the input with the Answer
             * Count the number of guesses
             * List of Letters the User has guessed
             */

            string answer = "Test";
            Console.WriteLine($"The word is {answer.Length} letters long.");

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append('_', answer.Length);

            Console.WriteLine(stringBuilder.ToString());
            
            while (true)
            {
                Console.WriteLine("Guess a letter");
                ConsoleKeyInfo input = Console.ReadKey(true);

                char inputUpperCased = char.ToUpperInvariant(input.KeyChar);
                for (int i = 0; i < answer.Length; i++)
                {
                    char letterUpperCased = char.ToUpperInvariant(answer[i]);
                    if (string.Equals(inputUpperCased.ToString(), letterUpperCased.ToString()))
                    {
                        stringBuilder.Replace('_', letterUpperCased, i, 1);
                    }
                }

                Console.WriteLine(stringBuilder.ToString());
            }
        }
    }
}