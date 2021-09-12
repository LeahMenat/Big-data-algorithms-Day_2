using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
   public class AllSorts
    {
        private static void swap(int[] arr, int a, int b)
        {
            int x = arr[a];
            arr[a] = arr[b];
            arr[b] = x;
        }
        public static void BubbleSort(int[] arr)
        {
            bool swapped;
            for (int i = 0; i < arr.Length; i++)
            {
                swapped = false;
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        swap(arr, j, j + 1);
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
        }

        public static void MergeSort(int[] arr)
        {
            MergeSort(arr, 0, arr.Length - 1);
        }
        private static void MergeSort(int[] arr, int start, int end)
        {
            if (start != end)
            {
                MergeSort(arr, start, (start + end) / 2);
                MergeSort(arr, ((start + end) / 2) + 1, end);
                Merge(arr, start, end);
            }
        }
        private static void Merge(int[] arr, int start, int end)
        {
            int a = start, b = ((start + end) / 2) + 1, index = 0;
            int[] temp = new int[(end - start) + 1];
            while (index != (end - start) + 1)
            {
                if (arr[a] < arr[b])
                {
                    temp[index++] = arr[a];
                    a++;
                    if (a == ((start + end) / 2) + 1)
                        while (b != end + 1)
                        {
                            temp[index++] = arr[b];
                            b++;
                        }
                }
                else
                {
                    temp[index++] = arr[b];
                    b++;
                    if (b == end + 1)
                        while (a != ((start + end) / 2) + 1)
                        {
                            temp[index++] = arr[a];
                            a++;
                        }
                }
            }
            for (int i = 0; i < temp.Length; i++)
            {
                arr[start + i] = temp[i];
            }
        }

        public static int BinarySearch(int[] arr, int num)
        {
            return BinarySearch(arr, 0, arr.Length - 1, num);
        }

        private static int BinarySearch(int[] arr, int start, int end, int num)
        {
            if (start == end)
                if (arr[start] == num)
                    return start;
                else
                    return -1;
            if (num <= arr[(start + end) / 2])
                return BinarySearch(arr, start, (start + end) / 2, num);
            else
                return BinarySearch(arr, ((start + end) / 2) + 1, end, num);
        }
    }
}
