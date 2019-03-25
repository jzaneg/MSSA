using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursiveMethodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //User is prompt to input a number
            Console.WriteLine($"Please enter a number.");
            //The user inputs a number and it is stored in a variable
            int inputNum = int.Parse(Console.ReadLine());
            int number = inputNum;
            //The result takes the output of the Factorial function
            int result = Factorial(number);
            //Writes the factorial number and the result
            Console.WriteLine($"The factorial of {inputNum} is {result}.");
            Console.ReadKey();
        }
        private static int Factorial (int number)
        {
            //checks if the input meets a condition ( less than 1 )
            if (number == 1)
                return 1;
            //if not takes the input number and multiplies it by the output of the function with the number -1
            return number * Factorial(number - 1);
        }
    }
}
