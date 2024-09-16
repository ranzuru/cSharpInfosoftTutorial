using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial
{
    class functionClass
    {
        static double result;
        public static void FunctionMain()
        {
            Console.WriteLine("Arithmetic Operator utilizing Array");
            

            Console.WriteLine("\nOperations");
            Console.WriteLine("a. ADDITION");
            Console.WriteLine("b. SUBTRACTION");
            Console.WriteLine("c. MULTIPLICATION");
            Console.WriteLine("d. DIVISION");
            Console.Write("\nWhich operation would you like to perform: ");
            string operation = Console.ReadLine();

            Console.Write("\nHow many numbers: ");
            int totalEntry = Convert.ToInt32(Console.ReadLine());
            double[] storeEntry = new double[totalEntry];
            Console.Write("\n");

            for (int i = 0; i < storeEntry.Length; i++)
            {
                Console.Write("Entry " + (i + 1) + ": ");
                double entry = Convert.ToDouble(Console.ReadLine());
                storeEntry[i] = entry;
            }

            if (operation.Equals("a", StringComparison.InvariantCultureIgnoreCase))
            {
                result = add(storeEntry);
                Console.WriteLine("\nResult of Addition: " + result);
            }
            else if (operation.Equals("b", StringComparison.InvariantCultureIgnoreCase))
            {
                result = subtract(storeEntry);
                Console.WriteLine("\nResult of Subtraction: " + result);
            }
            else if (operation.Equals("c", StringComparison.InvariantCultureIgnoreCase))
            {
                result = multiply(storeEntry);
                Console.WriteLine("\nResult of Multiplication: " + result);
            }
            else if (operation.Equals("d", StringComparison.InvariantCultureIgnoreCase))
            {
                result = divide(storeEntry);
                Console.WriteLine("\nResult of Division: " + result);
            }
        }

        static double add(double[] storedEntry)
        {
            double sum = 0;
            for (int i = 0; i < storedEntry.Length; i++)
            {
                sum += storedEntry[i];
            }
            return sum;
        }

        static double subtract(double[] storedEntry)
        {
            double difference = storedEntry[0];
            for (int i = 1; i < storedEntry.Length; i++)
            {
                difference -= storedEntry[i];
            }
            return difference;
        }

        static double multiply(double[] storedEntry)
        {
            double product = storedEntry[0];
            for (int i = 1; i < storedEntry.Length; i++)
            {
                product *= storedEntry[i];
            }
            return product;
        }

        static double divide(double[] storedEntry)
        {
            double qoutient = storedEntry[0];
            for (int i = 1; i < storedEntry.Length; i++)
            {
                qoutient /= storedEntry[i];
            }
            return qoutient;
        }

    }
}
