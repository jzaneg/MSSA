using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseItemsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            //"The Cat Ran Fast" => "Fast Ran Cat The"

            //WORKS

            string[] arr = new string[4] { "The", "Cat", "Ran", "Fast" };
            string[] arr2 = arr;
            Console.WriteLine("The original array is..");
            Console.WriteLine(arr[0] + " " + arr[1] + " " + arr[2] + " " + arr[3]);
            Console.WriteLine("The array when reversed is..");
            Console.WriteLine(arr2[3] + " " + arr2[2] + " " + arr2[1] + " " + arr2[0]);
            Console.ReadKey();
        }
    }
}
