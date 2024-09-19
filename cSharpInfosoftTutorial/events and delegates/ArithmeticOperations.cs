using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial.events_and_delegates
{
    class ArithmeticOperations
    {
        public static void AddOperation(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"The sum is: {result}");
        }
    }
}
