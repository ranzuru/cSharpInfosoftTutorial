using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial.loops
{
    class whileLoopClass
    {
        public static void Main()
        {
            Console.WriteLine("Odd/ Even Calculator");
            Console.WriteLine("Parities \na. Odd \nb. Even");
            Console.Write("Enter Parity: ");
            string parity = Console.ReadLine();
            Console.Write("Enter Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            int i = 1;

            if (parity.Equals("a", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("Odd Number/s of from 1 to " + num + ":");
            }
            else Console.WriteLine("Even Number/s of from 1 to " + num + ":");

            while (i <= num)
            {
                if (parity.Equals("a", StringComparison.InvariantCultureIgnoreCase))
                {

                    if (i % 2 != 0) Console.WriteLine(i);

                }
                else if (parity.Equals("b", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (i % 2 == 0) Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine("Invalid Parity Choice");
                    break;
                }
                i++;
            }
        }
    }
}
