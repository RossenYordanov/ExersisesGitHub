using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter array length: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] array = new int[n];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write("Enter element [{0}] = ", i);
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine();
            //Console.WriteLine("The elements of the array are:");
            //Console.WriteLine();

            //for (int j = 0; j < array.Length; j++)
            //{
            //    Console.WriteLine("Element [{0}] of the array is {1}", j, array[j]);
            //}

            //Console.WriteLine();
            //Console.WriteLine("The elements of the array in reverse order are:");
            //Console.WriteLine();

            //for (int k = array.Length-1; k >= 0; k--)
            //{
            //    Console.WriteLine("Element [{0}] of the array is {1}", k, array[k]);
            //}



            int[] array = new int[] { 1, 5, 1, 7, 4, 5, 6, 7, 8 };



            int counter = 1, numberOfElements = 1, newStart = 0, lastElement = 0;

            for (int i = 0; i < array.Length-1; i++)//subtract "array.Lengt" with 1, because the loop start with 0;
            {
                if (array[i]+1 == array[i+1])// Compare two nearby elements of the array whether they have the same value;
                {
                    counter++;
                    if (counter > numberOfElements)// if the next member in the array is bigger than the previous member, then:;
                    {
                        numberOfElements = counter;//assign the value of the variable "counter" to the variable  "numberOfElements";
                        lastElement = i + 1;//that variable show which is the last element of the row;
                        newStart = lastElement - numberOfElements + 1;//that variable show from which member of the array start the row;
                    }
                }
                else counter = 1;//reset counter;
            }
            for (int i = newStart; i < numberOfElements + newStart; i++)
                Console.Write("{0}, ", array[i]);







        }
    }
}

