using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial.events_and_delegates
{
    class delegatesClass
    {
        delegate void CalculatorDelegate(int a, int b);
        public static void Main()
        {
            // single cast delegate
            CalculatorDelegate calculator1 = ArithmeticOperations.AddOperation;
            calculator1(10, 5); // Output: The sum is: 15

            // multicast
            CalculatorDelegate calculator2 = ArithmeticOperations.AddOperation;
            calculator2 = Concatenator.Concatenation;
            calculator2(10, 5); // Output: The sum is: 15 | Concatenation: 105

            // anonymous
            CalculatorDelegate displayFirstNumber = delegate (int a, int b)
            {
                // inline content of the method
                Console.WriteLine("First Number: " + a); // output: First Number: 10
            };
        }
    }
  
}
