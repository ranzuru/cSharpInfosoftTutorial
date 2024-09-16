using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial
{
    internal class operatorsExpressionsClass
    {
        public static void OpEx()
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
            Console.Write("\nAverage: " + ave);

        }
    }
}
