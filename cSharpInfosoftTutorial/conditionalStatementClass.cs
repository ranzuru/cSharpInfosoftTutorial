using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial
{
    class conditionalStatementClass
    {
        public static void Conditional()
        {
            Console.WriteLine("BSIT Average Grade Calculator");
            Console.Write("Web Development: ");
            double webd = Convert.ToDouble(Console.ReadLine());
            Console.Write("Desktop Development: ");
            double desd = Convert.ToDouble(Console.ReadLine());
            Console.Write("Mobile Development: ");
            double mobd = Convert.ToDouble(Console.ReadLine());
            Console.Write("Networking: ");
            double netw = Convert.ToDouble(Console.ReadLine());
            Console.Write("Cybersecurity: ");
            double cybs = Convert.ToDouble(Console.ReadLine());

            double ave = (webd + desd + mobd + netw + cybs) / 5;

            if (ave > 100) Console.WriteLine(ave + " is an Invalid Grade");
            else
            {
                if (ave >= 98) Console.WriteLine("\nYour average grade is " + ave + ". You will be granted With Highest Honor.:");
                else if (ave >= 95) Console.WriteLine("\nYour average grade is " + ave + ". You will be granted With High Honor. ");
                else if (ave >= 90) Console.WriteLine("\nYour average grade is " + ave + ". You will be granted With Honor. ");
                else if (ave >= 75) Console.WriteLine("\nYour average grade is " + ave + ". You Passed. ");
                else Console.WriteLine("\nYour average grade is " + ave + ". You Failed. ");
            }

        }
    }
}
