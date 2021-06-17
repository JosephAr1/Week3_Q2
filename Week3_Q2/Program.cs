using System;

namespace Week3_Q2 // declare and initialize array of 10 integers then print the multiplication table of each element in the array
{
    class Program
    {
        static void Main(String[] numbers)
        {

            int[] numtable = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int i, j;
            
            {
                for (i = 1; i <=10; i++)
                {
                    for(j=1; j<=10; j++)
                    {
                        Console.Write(   i * j  );
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
