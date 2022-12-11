using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {7, 8, 3, 2, 1};
            Console.WriteLine("Unsorted List: " + String.Join(",",array));
            insertionSort(array);
            Console.WriteLine("Sorted List: " + String.Join(",", array));

        }

        public static void insertionSort(int[] array)
        {
            for (int i = 1; i<array.Length; i++)
            {
                int current = array[i];
                int j = i - 1;
                
                while(j>=0 && current < array[j])
                {
                    array[j + 1] = array[j];
                    j--;
                }

                //placement
                array[j + 1] = current;
            }
        }
    }
}
