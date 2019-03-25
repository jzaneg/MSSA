using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber_computerPlays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please pick a number between 1 and 100 for the computer to guess.");
            int playerNumber = 0;
            
            while (playerNumber < 1 || playerNumber > 100)
            {
                try
                {
                    playerNumber = int.Parse(Console.ReadLine());

                    if (playerNumber < 1)
                    {
                        Console.WriteLine("Please enter a number between 1 and 100.");
                    }
                    else if (playerNumber > 100)
                    {
                        Console.WriteLine("Please enter a number between 1 and 100.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number between 1 and 100.");
                }
            }
            isGuessCorrect(playerNumber);
            Console.ReadKey();
        }
        public static void isGuessCorrect(int pn)
        {
            Random r = new Random();

            int currentGuess = r.Next(1, 100);
            int leftHandIndex = 0;
            int rightHandIndex = 100;
            int guessCount = 0;

            List<int> computerGuesses = new List<int>();

            while (currentGuess != pn)
            {
                if (currentGuess < pn)
                {
                    guessCount++;
                    Console.WriteLine($"Guess number {guessCount} was too low.");
                    computerGuesses.Add(currentGuess);
                    leftHandIndex = currentGuess;
                    currentGuess = r.Next(leftHandIndex, rightHandIndex);
                }
                else if (currentGuess > pn)
                {
                    guessCount++;
                    Console.WriteLine($"Guess number {guessCount} was too high.");
                    computerGuesses.Add(currentGuess);
                    rightHandIndex = currentGuess;
                    currentGuess = r.Next(leftHandIndex, rightHandIndex);
                }
            }
            Console.WriteLine($"Correct! The computer's guessed your number was {currentGuess}.\nIt took {guessCount} attempts to find the correct number.");
            Console.WriteLine("The computers numbers were: {0}", string.Join(", ", computerGuesses));
        }
    }
}
