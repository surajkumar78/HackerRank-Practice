using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime
{
    class Program
    {
        static string timeConversion(string s)
        {
            var dayNightStatus = s.Trim().Substring(s.Length - 2);
            var hr = Convert.ToInt32(s.Split(':')[0]);
            var result = "";
            if (dayNightStatus.ToLower() == "pm")
            {
                if(hr != 12)
                {
                    hr = hr + 12;
                    if (hr == 24)
                        result = "00" + ":" + s.Split(':')[1] + ":" + s.Split(':')[2].Substring(0, 2);
                    else
                        result = hr.ToString() + ":" + s.Split(':')[1] + ":" + s.Split(':')[2].Substring(0, 2);
                }
                else
                {
                    result = "12" + ":" + s.Split(':')[1] + ":" + s.Split(':')[2].Substring(0, 2);
                }
                
            }
            else
            {
                if (hr == 12)
                    result = "00" + ":" + s.Split(':')[1] + ":" + s.Split(':')[2].Substring(0, 2);
                else
                    result = s.Substring(0, s.Length - 2);
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Date in 12hr format with AM or PM(Ex:hh:mm:ssAM or hh:mm:ssPM) ");
            string s = Console.ReadLine();

            string result = timeConversion(s);
            Console.WriteLine(result);
        }
    }
}
