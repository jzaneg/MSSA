using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9C
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            int leftHandIndex = 0;
            int rightHandIndex = list.Length + 1;
            int middleIndex = list.Length / 2;
            
            int[] greaterThanArr = new int[middleIndex];
            
            int userInput = 0;
            Console.WriteLine("Please enter a number between 1 and 10.");
            
            while (userInput < 1 || userInput > 10)
            {
                try
                {
                    userInput = int.Parse(Console.ReadLine());

                    if (userInput < 1)
                    {
                        Console.WriteLine("Please enter a number between 1 and 10.");
                    }
                    else if (userInput > 10)
                    {
                        Console.WriteLine("Please enter a number between 1 and 10.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number between 1 and 10.");
                }
            }
            while (userInput != middleIndex)
            {
                if (userInput == middleIndex)
                {
                    break;
                }
                else if (userInput < middleIndex)
                {
                    rightHandIndex = middleIndex;
                    middleIndex = (leftHandIndex + rightHandIndex) / 2;
                }
                else if (userInput > middleIndex)
                {
                    leftHandIndex = middleIndex;
                    middleIndex = (leftHandIndex + rightHandIndex) / 2;
                }
            }
            Console.WriteLine($"The player's number is {middleIndex}.");
            Console.ReadKey();
        }
    }
}
