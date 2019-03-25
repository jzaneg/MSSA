using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber_humanPlays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please guess the computer's number.");
            int playerGuess = 0;
            isGuessCorrect(playerGuess);

            Console.ReadKey();

        }
        public static void isGuessCorrect(int pg)
        {
            Random r = new Random();
            int computerNumber = r.Next(1, 1000);
            int guessCount = 0;

            while (pg < 1 || pg > 1000)
            {
                try
                {
                    pg = int.Parse(Console.ReadLine());

                    if (pg < 1)
                    {
                        Console.WriteLine("Please enter a number between 1 and 1000.");
                    }
                    else if (pg > 1000)
                    {
                        Console.WriteLine("Please enter a number between 1 and 1000.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number between 1 and 1000.");
                }
            }
            while (pg != computerNumber)
            {
                if (pg == computerNumber)
                {
                    break;
                }
                else if (pg < computerNumber)
                {
                    Console.WriteLine("Your number was too low, try again.");
                    try
                    {
                        pg = int.Parse(Console.ReadLine());

                        if (pg < 1)
                        {
                            Console.WriteLine("Please enter a number between 1 and 1000.");
                        }
                        else if (pg > 1000)
                        {
                            Console.WriteLine("Please enter a number between 1 and 1000.");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please enter a valid number between 1 and 1000.");
                    }
                }
                else if (pg > computerNumber)
                {
                    Console.WriteLine("Your number was too high, try again.");
                    try
                    {
                        pg = int.Parse(Console.ReadLine());

                        if (pg < 1)
                        {
                            Console.WriteLine("Please enter a number between 1 and 1000.");
                        }
                        else if (pg > 1000)
                        {
                            Console.WriteLine("Please enter a number between 1 and 1000.");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please enter a valid number between 1 and 1000.");
                    }
                }
                guessCount++;
            }
            Console.WriteLine($"Correct! The computer's number is {pg}.\nIt took {guessCount} attempts to find the correct number.");
        }
    }
}