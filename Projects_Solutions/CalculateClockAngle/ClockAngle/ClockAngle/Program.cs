using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockAngle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers for the hour and minute.");
            Console.WriteLine("Please enter the hour");
            int hour = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter minutes");
            int minutes = int.Parse(Console.ReadLine());
            calculateMinAngle(hour, minutes);
            //Console.WriteLine($"The hour angle is: .\nThe minutes clock angle is: {minutesAngle}.");
            Console.ReadKey();
        }
        static void calculateMinAngle(int Hr, int Mins)
        {
            int anglePerMinute = 360 / 60; //< -- for every minute, clock angle = 6;
            int minAngle = 0;
            minAngle = (Mins * anglePerMinute);
            int anglePerHour = 360 / 12; //< -- for every hour, clock angle = 30;
            int hrAngle = 0;
            hrAngle = (Hr * anglePerHour); 
            int hrAngleWithMins = hrAngle + ((hrAngle - minAngle) / 4);
            Console.Write($"The hour angle is : {hrAngleWithMins}\nThe minutes angle is: {minAngle}");
        }
    }
}
