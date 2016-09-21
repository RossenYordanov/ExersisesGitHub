using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
         class ArrayReverseExample
        {
            static void Main()
            {
                int[] array = { 1, 2, 3, 4, 5 };
                // Get array size
                int length = array.Length;
                // Declare and create the reversed array
                int[] reversed = new int[length];
                // Initialize the reversed array
                for (int index = 0; index < length; index++)
                {
                    reversed[length - index - 1] = array[index];
                }
                // Print the reversed array
                for (int index = 0; index < length; index++)
                {
                    Console.Write(reversed[index] + " ");
                }
            }
        }

    }
}

