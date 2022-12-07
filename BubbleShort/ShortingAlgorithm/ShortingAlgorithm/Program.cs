using System;

namespace ShortingAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unshortedList = { 40, 15, 17, 16, 25, 21, 75, 55, 76 };

            printUnshortedList(unshortedList);

            int[] shortedList = BubbleShort(unshortedList);
            printShortedList(shortedList);
        }

        //For printing unshorted list.
        public static void printUnshortedList(int[] unshortedList)
        {
            Console.WriteLine("Unshorted List: ");
            foreach (var item in unshortedList)
            {
                Console.Write(item + ",");
            }
        }

        //For printing shorted list.
        public static void printShortedList(int[] shortedList)
        {

            Console.WriteLine("\n Shorted List: ");
            foreach(var item in shortedList)
            { 
                Console.Write(item + ",");
            }
           

        }

        //BubbleShort 
        public static int[] BubbleShort(int[] unshortedList)
        {
            int temp;
            for(int i=0; i<unshortedList.Length-1; i++)
            {
                for(int j = 0; j <unshortedList.Length-(1+i); j++)
                {
                    if (unshortedList[j] > unshortedList[j + 1])
                    {

                        //Swap 
                        temp = unshortedList[j + 1];
                        unshortedList[j + 1] = unshortedList[j];
                        unshortedList[j] = temp;
                    }

                }
            }
            return unshortedList;

        }
    }
}
