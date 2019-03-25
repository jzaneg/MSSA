using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueWaysToClimbSteps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Please enter a number.");
            int N = int.Parse(Console.ReadLine()); //<== Number of steps
            //The result takes the output of the Factorial function
            int result = UniqueSteps(N);
            //Writes the facUniqueStepstorial number and the result
            Console.WriteLine($"The unique way of climbing {N} stairs is {result}.");
            Console.ReadKey();
        }
        private static int UniqueSteps(int number)
        {
            if (number > 1)
            {
                return UniqueSteps(number - 1) + UniqueSteps(number - 2);
            }
            return 1;
        }
    }
}
