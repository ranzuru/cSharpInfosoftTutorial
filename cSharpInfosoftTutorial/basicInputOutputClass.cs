using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial
{
     class basicInputOutputClass
    {
        // change to Main to run
        public static void BasicIO()
        {
            string name, coll, prog;

            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("College: ");
            coll = Console.ReadLine();
            Console.Write("Program: ");
            prog = Console.ReadLine();

            Console.WriteLine("\nI am " + name + ", presently studying the " + prog + " program under the College of " + coll + ".");
        }
    }
}
