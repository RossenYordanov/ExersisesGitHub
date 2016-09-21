using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
            int tempCount = 1;
            int count = 1;
            int number = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    tempCount++;
                }
                else
                {
                    tempCount = 1;
                }

                if (tempCount > count)
                {
                    count = tempCount;
                    number = arr[i];
                }
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("{0}, ", number);
            }


        }
    }
}
