using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 2, 4, 7, 1, 5 };
            PrintArray(array);
            Console.WriteLine("Mean Value: " + CalculateMeanValue(array));
            ReverseArray(array);
            PrintArray(array);
            Console.ReadKey();
        }
        static void PrintArray(int[] array)
        {
            string arr = "";
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length -1)
                {
                    arr += array[i] + ", ";
                }
                else
                {
                    arr += array[i];
                }
            }
            Console.WriteLine("Array:{"+arr+"}");
        }
        static double CalculateMeanValue(int[] array)
        {
            double MeanValue = array.Average();
            return MeanValue;
        }
        static void ReverseArray(int[] array)
        {
            for (int j = 0; j < array.Length / 2; j++)
            {
                int temp = array[j]; // <-- sets the temp var = to array @ index j
                array[j] = array[array.Length - 1 - j];// <-- sets the array @ index j = to array @ index - 1 minus index j.
                array[array.Length - 1 - j] = temp;// <-- sets the array @ index j = to array @ index - 1 minus index j = temp var.

            }
        }
    }
}
