using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {4, 1, 2, 8, 3, 5};
            BubbleSort(array);
            Console.ReadKey();
        }
        static void BubbleSort(int[] arr)
        {

            for (int j = 0; j < arr.Length; j++)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i < arr.Length - 1)
                    {
                        if (arr[i] > arr[i + 1])
                        {
                            int temp = arr[i];
                            arr[i] = arr[i + 1];
                            arr[i + 1] = temp;
                        }
                    }
                }
            }
            foreach (int i in arr)
            {
                Console.Write($"{i}", arr);
            }
        }

    }
}
