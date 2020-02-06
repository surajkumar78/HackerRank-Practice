using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {
        static void miniMaxSum(int[] arr)
        {
            Array.Sort(arr);
            long minSum = 0;
            long maxSum = 0;
            for(var i=0; i<arr.Length; i++)
            {
                if (i != 0)
                    maxSum += arr[i];
                if (i != arr.Length - 1)
                    minSum += arr[i];
            }
            Console.WriteLine(minSum + " " + maxSum);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a list of integers : ");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            miniMaxSum(arr);
        }
    }
}
