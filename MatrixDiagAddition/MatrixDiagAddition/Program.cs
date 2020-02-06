using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixDiagAddition
{
    class Program
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            var diag1 = 0;
            var diag2 = 0;
            string diagonal1 = "";
            string diagonal2 = "";
            var j = 0;
            foreach(List<int> subList in arr)
            {
                for(var i=0; i< subList.Count;)
                {
                    diag1 = diag1 + subList[i + j] ;
                    diag2 = diag2 + subList[subList.Count - j - 1];
                    diagonal1 = diagonal1 + subList[i + j] + " + ";
                    diagonal2 = diagonal2 + subList[subList.Count - j - 1] + " + ";
                    break;
                }
                j++;
            }
            Console.WriteLine(diagonal1.Substring(0,diagonal1.Length-1) + " : " + diag1);
            Console.WriteLine(diagonal2.Substring(0,diagonal2.Length-1) + " : " + diag2);
            return Math.Abs(diag1 - diag2);
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Program.diagonalDifference(arr);
            Console.WriteLine(result);
        }
    }
}
