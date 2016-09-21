using System;


namespace Problem2bookCSharp
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            if (n != m)
            {
                Console.WriteLine("The arrays are not same!");
            }
            else
            {
                int[] arrayOne = new int[n];
                int[] arrayTwo = new int[m];
              
                bool arraysEqual = true;
                for (int i = 0; i < arrayOne.Length; i++)
                {
                    arrayOne[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < arrayTwo.Length; i++)
                {
                    arrayTwo[i] = int.Parse(Console.ReadLine());
                }
                for (int index = 0; index < n; index++)
                {
                   
                    if (arrayOne[index] != arrayTwo[index])
                    {
                        Console.WriteLine("The arrays are not same!");
                        arraysEqual = false;
                        break;
                    }
                  
                }
                if (arraysEqual == true)
                {
                    Console.WriteLine("The arrays are the same!");
                }
                
            }
        }
    }
}
