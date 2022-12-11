using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[] { 3, 2, 8, 4, 9 };
            int[] array = { 51, 66, 72, 42, 38, 62};
            int n = array.Length;
            Console.WriteLine("Unsorted List : " + String.Join(", ", array));
            quickSort(array, 0, n - 1);
            Console.WriteLine("Sorted List : " + String.Join(",", array));
        }

        public static int partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low-1;

            for (int j = low; j<high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    //swap
                    int tem = array[i];
                    array[i] = array[j];
                    array[j] = tem;
                }
               
            }
            //swap
            i++;
            int temp = array[i];
            array[i] = pivot;
            array[high] = temp;

            return i; 
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
