using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrOfNums_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 8, 2, 1, 4, 9, 3 };
            sortArray(arr);
            Console.WriteLine(sortArray(arr));
            Console.ReadKey();

        }
        static void sortArray(int[] arr)
        {
            int index;
            int i;

            for (index = 0; index < arr.Length; index++)
            {
                    int minV = index;
                    int minI = arr[minV];

                    for (i = index; i < arr.Length; i++)
                    {
                        if (arr[i] < minV)
                        {
                            minV = arr[i];
                            minI = i;
                        }
                    }
                    int temp;
                    temp = arr[0];
                    arr[0] = arr[1];
                    arr[1] = temp;
            }
        }
    }
}
