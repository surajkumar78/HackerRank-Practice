using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTriplets
{
    class Program
    {
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            var result = new List<int>();
            var alicePoints = 0;
            var bobPoints = 0;
            for(var i=0; i < a.Count(); i++)
            {
                if (a[i] > b[i])
                    alicePoints++;
                else if (a[i] < b[i])
                    bobPoints++;
                else
                { }
            }
            result.Add(alicePoints);
            result.Add(bobPoints);
            return result;
        }

        
        static void Main(string[] args)
        {
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
