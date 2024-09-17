using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial.oopBasics
{
    class oopBasics3Class
    {
        public static void Main()
        {
            Console.WriteLine("Term Exam Calculator\n");
            Console.Write("1st Exam (/100)  : ");
            double firstExam = Convert.ToDouble(Console.ReadLine());
            Console.Write("2nd Exam (/100)  : ");
            double secondExam = Convert.ToDouble(Console.ReadLine());
            Console.Write("3rd Exam (/100)  : ");
            double thirdExam = Convert.ToDouble(Console.ReadLine());
            Console.Write("Final Exam (/100): ");
            double finalExam = Convert.ToDouble(Console.ReadLine());

            termGradeClass grade = new termGradeClass(firstExam, secondExam, thirdExam, finalExam);

            Console.WriteLine("\n" + grade.getResult() + " is your final exam grade.");
            if (grade.getResult() > 100) Console.WriteLine(grade.getResult() + " is an Invalid Grade!");
            else
            {
                // condition statement results is calling object methods
                if (grade.getResult() >= 98) Console.WriteLine(grade.highestHonorDialog());
                else if (grade.getResult() >= 95) Console.WriteLine(grade.highHonorDialog());
                else if (grade.getResult() >= 90) Console.WriteLine(grade.honorDialog());
                else if (grade.getResult() >= 75) Console.WriteLine(grade.passedDialog());
                else Console.WriteLine(grade.failedDialog());
            }
        }
    }
}
