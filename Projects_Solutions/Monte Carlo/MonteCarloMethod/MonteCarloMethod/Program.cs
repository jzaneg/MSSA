using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloMethod
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of test cases.");
            Points[] points = new Points[int.Parse(Console.ReadLine())];

            Random rndm = new Random();

            Points P1 = new Points(rndm.NextDouble(), rndm.NextDouble());
            double p1Hypot = calcHypotenuse(P1);

            Points P2 = new Points(rndm);
            double p2Hypot = calcHypotenuse(P2);
            
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Points(rndm.NextDouble(), rndm.NextDouble());
            }

            int bluePoints = 0;
            int redPoints = 0;

            for (int j = 0; j < points.Length; j++)
            {
                if (calcHypotenuse(points[j]) <= 1.0)
                {
                    bluePoints++;
                }
                else
                {
                    redPoints++;
                }
            }
            double bluePointPrct = ((bluePoints / (double)points.Length)) * 100;

            Console.WriteLine($"The number of blue points is: {bluePoints}.");
            Console.WriteLine($"Thats a {bluePointPrct}% of a random point landing in the blue.");

            double piApprox = (bluePoints / (double)points.Length) * 4.0;
            double piDiff = Math.Abs(Math.PI - piApprox);

            Console.WriteLine($"The approximate value of pi is: {piApprox}.");
            Console.WriteLine($"The actual value of pi is: {Math.PI}.");
            Console.WriteLine($"The absolute difference of calculated pi and actual pi is: {piDiff}.");
            Console.ReadKey();
        }
        static double calcHypotenuse(Points cords)
        {
            return Math.Sqrt(Math.Pow(cords.x, 2) + Math.Pow(cords.y, 2)); //<=== inside = blue outside = red
        }
        
    }
    public struct Points
    {
        public double x;
        public double y;
       
        public Points(double xCord, double yCord) // <== constructor name must == struct name
        {
            x = xCord;
            y = yCord;
        }
        public Points(Random rndmPoint) // <== constructor name must == struct name
        {
            this.x = rndmPoint.NextDouble();
            this.y = rndmPoint.NextDouble();
        }
    }
}
