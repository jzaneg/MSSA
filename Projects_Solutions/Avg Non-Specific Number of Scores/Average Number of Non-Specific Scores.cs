using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avg_Non_Specific_Number_of_Scores
{
    class avgNonSpecificNumberOfScores
    {
        static void Main(string[] args)

        {
            //Variables
            int userInput = 0;
            int sum = 0;
            int avg = 0;
            int countOfScores = 0;

            // Enter scores
            Console.WriteLine($"Please enter the test scores. When finished, enter -1 to exit.");

            //Call the sum method
            calculateSum();
            Console.WriteLine($"The sum of the scores is {sum}.");
            //Call the avg method
            calculateAvg();
            Console.WriteLine($"The average is {avg}.");
            //Call the letter grade method
            calculateLetterGrade();

            Console.ReadKey();

            void calculateSum()
            {
                userInput = int.Parse(Console.ReadLine());
                if (userInput >= 0 && userInput <= 100)
                {
                    sum += userInput;
                    Console.WriteLine($"Please enter next score.");
                    countOfScores++;
                    calculateSum();
                }
                else if (userInput == -1)
                {
                    return;
                }
                else
                {
                    return;
                }

            }
            void calculateAvg()
            {
                avg = (sum / countOfScores);
                return;
            }

            void calculateLetterGrade()
            {
                if (avg > 90)
                {
                    Console.WriteLine("The average grade is: A");
                }
                else if (avg <= 89 && avg >= 80)
                {
                    Console.WriteLine("The average grade is: B");
                }
                else if (avg <= 79 && avg >= 71)
                {
                    Console.WriteLine("The average grade is: C");
                }
                else if (avg == 70)
                {
                    Console.WriteLine("The average grade is: D");
                }
                else if (avg < 69)
                {
                    Console.WriteLine("The average grade is: F");
                }
            }
        }
    }
}
