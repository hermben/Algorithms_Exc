using System;
using static System.Console;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int theValue = 43;
            int[] array = new int[] { 11, 22, 43, 54, 57, 59, 62, 78 };

            WriteLine("Our array contains: ");
            Array.ForEach(array, x => Write(x + " "));

            Write($"\n\nThe result of a binary search for {theValue} is: ");
            WriteLine(BinarySearch(array, 43));
        }
        /*a = array
         * x = what were searching
         * p = first index
         * q = midpoint
         * r = last index
         */
        public static int BinarySearch(int[] a, int x)
        {
            //step 1 initialize
            int p = 0; //begining
            int r = a.Length - 1; // end of range

            //step 2 search for value
            while(p <=r )
            {
                int q = (p + r) / 2; //mid point
                if (x < a[q])
                {
                    r = q - 1;//set r to midpoint
                }
                else if(x>a[q])
                {
                    p = q + 1;//set p to right of array
                }
                else
                {
                    return q;
                }
            }
            //step 3 nothing found
            return -1;
        }
    }
}
