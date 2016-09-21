using System;


namespace Problem1bookCSharp
{
    class Program
    {
        static void Main()
        {
            int[] array= new int[20];

            for (int index = 0; index < array.Length; index++)
            {
                array[index] = index * 5;
                Console.Write(array[index]+" ");
            }
            Console.WriteLine();

        }
    }
}
