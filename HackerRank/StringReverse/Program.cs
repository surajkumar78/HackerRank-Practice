using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    class Program
    {
        public static List<string> StrReverse(string str)
        {
            var input = new List<char>(str);
            var strRev = new List<string>();
            var j = 0;
            for(var i = input.Count-1;i >= 0; i--)
            {
                var jh = input[i];
                strRev.Add(input[i].ToString());
                j++;
            }
            return strRev;
        }

        public static string StringRev(string str)
        {
            StringBuilder strReverse = new StringBuilder();
            for(var i= str.Length-1; i>=0; i--)
            {
                strReverse.Append(str[i]);
            }

            return strReverse.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a string");
            string input = Console.ReadLine();
            Console.Write("Reversed String is : ");
            foreach (var item in StrReverse(input))
            {
                Console.Write(item);
            }
            Console.WriteLine();

            Console.WriteLine("*****By using String Builder*****");
            Console.WriteLine(StringRev(input)); 
        }
    }
}
