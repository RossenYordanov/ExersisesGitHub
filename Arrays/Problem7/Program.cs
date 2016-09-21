using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int k = 2;
            int []arr = new int[] {7,2,7,4,1 };
                       
            int maxSum = int.MinValue;
            int maxStart = 0;
            for (int i = 0; i < n - k + 1; i++)
            {
                int sum = 0;
                for (int j = 0; j < k; j++)
                {
                    sum += arr[i + j];
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxStart = i;
                }
            }

            for (int j = 0; j < k; j++)
            {
                Console.Write(arr[maxStart + j] + "; ");
            }
        }

    }
    
}
