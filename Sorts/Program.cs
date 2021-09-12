using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{

    public static class PrintArray
    {
        public static void Print(this int[] arr)
        {
            string str = "";
            for (int i = 0; i < arr.Length; i++)
            {
                str += arr[i] + ", ";
            }
            Console.WriteLine(str.Substring(0, str.Length - 2));
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] arr2 = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] arr3 = { 5, 3, 6, 3, 2, 8, 6, 8, 9, 0, 11 };
            //AllSorts.BubbleSort(arr1);
            //AllSorts.BubbleSort(arr2);
            //AllSorts.BubbleSort(arr3);            
            //AllSorts.MergeSort(arr1);
            //AllSorts.MergeSort(arr2);
            //AllSorts.MergeSort(arr3);
            //arr1.Print();
            //arr2.Print();
            //arr3.Print();
            Console.WriteLine(AllSorts.BinarySearch(arr1, 4));
            Console.WriteLine(AllSorts.BinarySearch(arr2, 11));


            Console.WriteLine("Hello World!");
        }
    }
}