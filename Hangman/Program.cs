using System;
using System.Text;
using System.Collections.Generic;

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
            int numberOfGuesses = 0;
            List<char> guessedLetters = new List<char>();

            List<string> possibleAnswers = new List<string>
            {
                "Test",
                "Apa",
                "Gurkan",
                "Jonte"
            };
            
            int randomIndex = new Random().Next(0, possibleAnswers.Count);
            string answer = possibleAnswers[randomIndex].ToUpperInvariant();
            Console.WriteLine($"The word is {answer.Length} letters long.");

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append('_', answer.Length);

            Console.WriteLine(stringBuilder.ToString());
            
            while (numberOfGuesses < answer.Length)
            {
                Console.WriteLine("Guess a letter");
                ConsoleKeyInfo input = Console.ReadKey(true);

                char inputUpperCased = char.ToUpperInvariant(input.KeyChar);
                if (guessedLetters.Exists(letter => letter == inputUpperCased))
                {
                    Console.WriteLine($"You have already guessed that: {input.KeyChar}");
                    
                    // continue - Goes back to the start of the loop.
                    continue; 
                }

                if(answer.Contains(inputUpperCased))
                {
                    for (int i = 0; i < answer.Length; i++)
                    {
                        if (string.Equals(inputUpperCased.ToString(), answer[i].ToString()))
                        {
                            stringBuilder.Replace('_', answer[i], i, 1);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Guess again!");
                }
                
                numberOfGuesses++;
                guessedLetters.Add(inputUpperCased);
                
                if (stringBuilder.ToString().Equals(answer.ToUpperInvariant()))
                {
                    break;
                }
                
                Console.WriteLine(stringBuilder.ToString());
            }
            
            if (stringBuilder.ToString().Equals(answer.ToUpperInvariant()))
            {
                Console.WriteLine($"You won, it took you {numberOfGuesses} times!{Environment.NewLine}" +
                                  $"The correct word was: {answer}");
            }
            else
            {
                Console.WriteLine("You hung the man, his family will starve.");
            }
        }
    }
}