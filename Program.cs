/*
Author: Jonathan Tsokos
Date: 2/7/23
Description: C# Console Application for Arrays
*/

using System;
namespace deliverable_4__Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacci = new int[25];

            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 0; i < 25; i++)
            {

                if (i >= 2)
                {
                    fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
                }

            }

            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("Fibonacci number (" + i + ") = " + fibonacci[i]);
            }
        }
    }
}
