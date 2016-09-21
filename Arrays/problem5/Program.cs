using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1,2, 1,3, 4,5 };

            int sames = 1, bestSames = 1, bestStart = 0, lastElement = 0;

            int a = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] + 1 == arr[i + 1])
                {
                    sames++;
                    if (sames > bestSames)
                    {
                        bestSames = sames;
                        lastElement = i + 1;
                        bestStart = lastElement - bestSames + 1;
                        a = arr[i];
                    }
                }
                else sames = 1;
            }

            for (int i = bestStart; i < bestSames + bestStart; i++)
                Console.Write("{0}, ", arr[i]);
        }
    }
}
