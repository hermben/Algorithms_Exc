using static System.Console;
using System;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int theValue = 7;
            int[] array = new int[] { 1, 4, 5, 7, 9, 22 };
            WriteLine("Our array contains:");
            Array.ForEach(array, x => Write(x + " "));

            Write($"\n\nThe result of a linear search for {theValue} is: ");
            WriteLine(LinearSearch(array, theValue));
        }

        static int LinearSearch(int[] a, int x)
        {
            //step 2
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i]==x)
                {
                    return i;
                }
            }
            //step 3
            return -1;
        }
    }
}
