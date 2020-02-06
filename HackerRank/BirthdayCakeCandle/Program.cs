using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCakeCandle
{
    class Program
    {
        static int birthdayCakeCandles(int[] ar)
        {
            Array.Sort(ar);
            var maxHeight = ar[ar.Length - 1];
            
            //Number of candle which will get burned by her
            var numberOfCandle = 0;
            foreach(var item in ar)
            {
                if (item == maxHeight)
                    numberOfCandle++;
            }
            return numberOfCandle;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of candles :");
            int arCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter heights for " + arCount + " candles : ");
           
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = birthdayCakeCandles(ar);

            Console.WriteLine(result);
        }
    }
}
