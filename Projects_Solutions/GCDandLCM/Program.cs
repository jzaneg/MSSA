using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDandLCM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first value.");
            int valueA = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second value.");
            int valueB = int.Parse(Console.ReadLine());

            Console.WriteLine("The greatest common divisor = " + computeGCD(valueA, valueB));
            Console.WriteLine("The lease common multiple = " + computeLCM(valueA, valueB));

            Console.ReadKey();
        }
        static int computeGCD(int valueA, int valueB)
        {
            int gcd = 1;

            for (int i = 1; i <= Math.Min(valueA, valueB); i++)
            {
                if(valueA % i == 0 && valueB % i == 0)
                {
                    gcd = i;
                    
                }
            }
            return gcd;
        }
        static int computeLCM(int valueA, int valueB)
        {
            int lcm = valueA * valueB;
            for (int i = lcm; i >= Math.Max(valueA, valueB); i--)
            {
                if (i % valueA == 0 && i % valueB == 0)
                {
                    lcm = i;
                }
            }
            return lcm;
        }
    }
}
