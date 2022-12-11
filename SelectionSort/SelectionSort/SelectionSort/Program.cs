using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {7, 8, 3, 1, 2};
            Console.WriteLine("Unsorted List: "+ String.Join(",",array));
            selectionSort(array);
            Console.WriteLine("Sorted List: " + String.Join(",", array));
        }


        public static void selectionSort(int[] array)
        {
            for (int i = 0; i<array.Length; i++)
            {
                int smallest = i;
                for (int j = i+1; j<array.Length; j++)
                {
                    if (array[smallest] > array[j])
                    {
                        smallest = j;
                    }
                }
                int temp = array[smallest];
                array[smallest] = array[i];
                array[i] = temp;
            }

        }
    }
}