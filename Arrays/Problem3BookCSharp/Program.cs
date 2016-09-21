using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3BookCSharp
{
    class Program
    {
        static void Main()
        {
            char[] array2 = { 'a', 'a', 'c' };
            char[] array1 = { 'a', 'c', 'c' };
            bool arrayEqual = true;

            if (array1.Length < array2.Length)
            {
                Console.WriteLine("Array 1 is lexicographicaly first");
            }
            else if (array1.Length > array2.Length)
            {
                Console.WriteLine("Array 2 is lexicographicaly first");
            }
            else
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] < array2[i])
                    {
                        Console.WriteLine("Arrey 1 is lexicographicaly first");
                        arrayEqual = false;
                        break;
                    }
                    else if (array1[i] > array2[i])
                    {
                        Console.WriteLine("Arrey 2 is lexicographicaly first");
                        break;
                        arrayEqual = false;
                    }

                }
                if (arrayEqual)
                {
                    Console.WriteLine("The Array 1 and Array 2 are lexicographicaly equal");
                }
            }
        }
    }
}
