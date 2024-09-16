using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial
{
    class constructorClass
    {
        public string email;
        public string name;
        public string department;
        public string program;

        public constructorClass(string email, string name, string department, string program)
        {
            this.email = email;
            this.name = name;
            this.department = department;
            this.program = program;

            Console.WriteLine("\n\nUser Account Created!\n");
            Console.WriteLine("Email     : " + email);
            Console.WriteLine("Name      : " + name);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("Program   : " + program);
        }
    }
}
