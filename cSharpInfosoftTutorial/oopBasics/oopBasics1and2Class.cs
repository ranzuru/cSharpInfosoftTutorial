using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial.oopBasics
{
    class oopBasics1and2Class
    {
        public static void Main()
        {
           Console.WriteLine("User Information Registration\n");
           Console.Write("Email    :");
           string email = Console.ReadLine();
           Console.Write("Name     :");
           string name = Console.ReadLine();
           Console.Write("Deparment:");
           string department = Console.ReadLine();
           Console.Write("Program  :");
           string program = Console.ReadLine();
           // class instantiation
           constructorClass user = new constructorClass(email, name, department, program);
        }
    }
}
