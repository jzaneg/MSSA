using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the digits you want to have reversed.");
            int inputValue = int.Parse(Console.ReadLine());
            
            Console.WriteLine(reverseDigits(inputValue));

            Console.ReadKey();

        }
        //reads the inputVale and applies it to the variable values
        static int reverseDigits(int values)
        { 
            int returnValue = 0;
            //while the inputValue is greater than 0..
            while (values > 0)
            {
                //pushes the returnValue digit over one place
                returnValue = returnValue * 10;
                //adds  the remainder of values / 10 to returnValue
                returnValue += values % 10;
                //alters the values value to return the remaining digits minus the last digit.
                values = values / 10;  
            }
            return returnValue;
        }
    }
}
