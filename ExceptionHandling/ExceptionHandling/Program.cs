using System;
using System.Runtime.CompilerServices;

namespace ExceptionHandling
{
    class ExceptionHandling
    {

        public static void Main()
        {
            int[] arrayInteger = new int[5] { 99, 88, 77, 66, 55 };

            //printing the index of the arrays
            for (int i = 0; i < arrayInteger.Length; i++)
            {
                Console.WriteLine($"Index {i} of the array.");
            }

            //using try catch block to handle indexoutofrange exception 
            try
            {
                Console.WriteLine("\nElements of Array : ");
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine($"Element at index {i} is {arrayInteger[i]}");
                }

            } catch (IndexOutOfRangeException ex)
            {
                //printing the exception message
                Console.WriteLine($"Exception : {ex.Message}");
            }
            finally {

                Console.WriteLine("\nThis is finally block.");
            }
           
        }
    }
}