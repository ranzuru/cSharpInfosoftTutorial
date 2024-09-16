/* 
 * when executing the codes below (up to functionClass), uncomment the "using cSharpInfosoftTutorial",
 * then uncomment each class.
 */

//using cSharpInfosoftTutorial;
//introductionClass.Introduction();
//variabesDatatypesClass.VarDt();
//basicInputOutputClass.BasicIO();
//operatorsExpressionsClass.OpEx();
//conditionalStatementClass.Conditional();
//switchClass.Switch();
//whileLoopClass.WhileLoop();
//forLoopClass.ForLoop();
//arraysClass.Array();
//functionClass.FunctionMain();


// before executing the codes above, transform all codes below into comment
using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpInfosoftTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // for constructorClass.cs, oop basics - classes & objects, and constructors
            //Console.WriteLine("User Information Registration\n");
            //Console.Write("Email    :");
            //string email = Console.ReadLine();
            //Console.Write("Name     :");
            //string name = Console.ReadLine();
            //Console.Write("Deparment:");
            //string department = Console.ReadLine();
            //Console.Write("Program  :");
            //string program = Console.ReadLine();
            //constructorClass user = new constructorClass(email, name, department, program);

            // for studentClass.cs, oop basics - object methods
            //Console.WriteLine("Term Exam Calculator\n");
            //Console.Write("1st Exam (/100)  : ");
            //double firstExam = Convert.ToDouble(Console.ReadLine());
            //Console.Write("2nd Exam (/100)  : ");
            //double secondExam = Convert.ToDouble(Console.ReadLine());
            //Console.Write("3rd Exam (/100)  : ");
            //double thirdExam = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Final Exam (/100): ");
            //double finalExam = Convert.ToDouble(Console.ReadLine());

            //termGradeClass grade = new termGradeClass(firstExam, secondExam, thirdExam, finalExam);

            //Console.WriteLine("\n" + grade.getResult() + " is your final exam grade.");
            //if (grade.getResult() > 100) Console.WriteLine(grade.getResult() + " is an Invalid Grade!");
            //else
            //{
            //    if (grade.getResult() >= 98) Console.WriteLine(grade.highestHonorDialog());
            //    else if (grade.getResult() >= 95) Console.WriteLine(grade.highHonorDialog());
            //    else if (grade.getResult() >= 90) Console.WriteLine(grade.honorDialog());
            //    else if (grade.getResult() >= 75) Console.WriteLine(grade.passedDialog());
            //    else Console.WriteLine(grade.failedDialog());
            //}

            //for inheritance
            heroInformation hero1 = new heroInformation();
            hero1.name = "Storm Spirit";
            hero1.otherName = "Raijin Thunderkeg";
            hero1.displayHeroInfoData();

            basicStatsInheritanceClass hero2 = new basicStatsInheritanceClass();
            hero2.name = "Alchemist";
            hero2.otherName = "Razzil Darkbrew";
            hero2.strength = 5;
            hero2.agility = 3;
            hero2.intelligence = 2;
            hero2.displayHeroInfoData();
        }
    }
    class heroInformation()
    {
        public string name { get; set; }
        public string otherName { get; set; }

        public void displayHeroInfoData()
        {
            Console.WriteLine("\nName      : " + name);
            Console.WriteLine("Other Name: " + otherName);
        }
    }

}