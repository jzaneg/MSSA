using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrOfNums_binarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; 
            int lhi = 0;
            int rhi = arr.Length - 1;
            int mi = (lhi + rhi) / 2;
            int searchNum = 2;
            //Evalutates while lhi does not equal rhi
            while (lhi != rhi)
            {
                if (searchNum == arr[mi])
                {
                    break;
                }
                else if (searchNum < arr[mi])
                {
                    rhi = mi;
                    mi = (lhi + rhi) / 2;
                }
                else if (searchNum > arr[mi])
                {
                    lhi = mi;
                    mi = (lhi + rhi) / 2;
                }
            }
            Console.WriteLine("Found " + searchNum + " at " + mi);
            Console.ReadKey();
        }
    }
}
