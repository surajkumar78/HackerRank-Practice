using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus
{
    class Program
    {
        static void plusMinus(int[] arr)
        {
            var positiveNumCount = 0;
            var negativeNumCount = 0;
            var Zeroscount = 0;
            foreach(var item in arr)
            {
                if (item > 0)
                    positiveNumCount++;
                else if (item < 0)
                    negativeNumCount++;
                else
                    Zeroscount++;
            }
            Console.WriteLine(((double) positiveNumCount / arr.Count()).ToString("N6"));
            Console.WriteLine(((double) negativeNumCount / arr.Length).ToString("0.000000"));
            Console.WriteLine(string.Format("{0:N6}", (double) Zeroscount / arr.Count()));            
        } 

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Size of the Array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            plusMinus(arr);
        }
    }
}
