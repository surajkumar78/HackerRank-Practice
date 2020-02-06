using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingStudents
{
    class Program
    {
        public static List<int> gradingStudents(List<int> grades)
        {
            var roundedGrades = new List<int>();
            foreach(var grade in grades)
            {
                if (grade < 40 && grade + 2 < 40)
                    roundedGrades.Add(grade);
                else
                {
                    var difference = grade % 5;
                    if (difference >= 3)
                    {
                        roundedGrades.Add(grade + (5 - difference));
                    }
                    else
                        roundedGrades.Add(grade);
                }
            }
            return roundedGrades;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students (Note : Maximum 60) : ");
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> results = Program.gradingStudents(grades);
            Console.WriteLine("*****Result*****");
            foreach(var result in results)
            {
                Console.WriteLine(result);
            }
            
        }
    }
}
