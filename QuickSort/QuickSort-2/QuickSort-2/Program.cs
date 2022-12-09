using System;

namespace QuickSort_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] array = new int[] { 3, 2, 8, 4, 9 };
            int[] array = { 51, 95, 66, 72, 42, 38, 62 };
            int n = array.Length;
            quickSort(array, 0, n-1);
            Console.WriteLine("Unsorted List : " + String.Join(", ", array));
            Console.WriteLine("Sorted List : " + String.Join(",", array));
        }

        public static int partition(int[] array, int low, int high)
        {
            int pivot = array[low];
            int i = low+1;
            int j = high;

            do
            {
                while (array[i] <= pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }

                if (i < j)
                {
                    //swap
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            while (i<j);

            //Swap 
            int tem = array[low];
            array[low] = array[j];
            array[j] = tem;
            return j;
        }

        public static void quickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pindx = partition(array, low, high);
                quickSort(array, low, pindx - 1);
                quickSort(array, pindx + 1, high);
            }

        }
    }
}
