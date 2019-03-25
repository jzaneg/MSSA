using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1A_MathFunctions
{
    class Program
    {
        static void Main(string[] args)
        {   //user input//
            Console.WriteLine("Please enter a radius value to calculate the circumference and area.");
            string userInputRadiusValueProb1 = Console.ReadLine();
            //type conversions and calculations//
            double radiusValue = double.Parse(userInputRadiusValueProb1);
            double convertedValue = Convert.ToDouble(userInputRadiusValueProb1);
            double circumference = 2.0 * Math.PI * radiusValue;
            double area = Math.PI * radiusValue * radiusValue;
            //calculation output//
            Console.WriteLine("Circumference = " + circumference);
            Console.WriteLine("Area = " + area);
            Console.ReadKey();
        }
    }
}
