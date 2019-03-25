using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stormClassification
{
    class Program
    {
        static string classifyStorm(double windSpeed)
        {
            string classification = "";

            if (windSpeed < 39)
                classification = "Tropical Depression";
            else if (windSpeed > 39 && windSpeed < 73)
                classification = "Tropical Storm";
            else if (windSpeed > 74 && windSpeed < 95)
                classification = "Category 1 Hurricane";
            else if (windSpeed > 95 && windSpeed < 110)
                classification = "Category 2 Hurricane";
            else if (windSpeed > 110 && windSpeed < 130)
                classification = "Category 3 Hurricane";
            else if (windSpeed > 130 && windSpeed < 155)
                classification = "Category 4 Hurricane";
            else if (windSpeed > 155)
                classification = "Category 5 Hurricane";

            return classification;
        }
        static void Main(string[] args)
        {
            string inputSpeed;
            string stormClassification;

            Console.WriteLine("Please enter the current wind speed.");
            inputSpeed = Console.ReadLine();

            stormClassification = classifyStorm(double.Parse(inputSpeed));
            Console.WriteLine("The storm is currently a " + stormClassification + ".");
            Console.ReadKey();


        }
    }   
}
