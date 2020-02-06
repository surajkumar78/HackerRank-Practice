using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Program
    {
        static void staircase(int size)
        {
            for(var i = 0; i< size; i++)
            {
                for(var j=size-1; j>=0; j--)
                {
                    if(i>=j)
                        Console.Write("#");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the stairs: between 1 to 100" );
            int n = Convert.ToInt32(Console.ReadLine());
            staircase(n);
        }
    }
}
