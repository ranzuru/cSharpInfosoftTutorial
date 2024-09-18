using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial
{
    class exceptionHandlingClass
    {
        public static void Main()
        {
            try
            {
                Console.Write("Number/s: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.Write("Letter: ");
                char letter = Convert.ToChar(Console.ReadLine());

                Console.WriteLine(num + " - " + letter);
                
            }
            catch (Exception e)
            {
                Console.WriteLine("\nERROR! ");
                Console.WriteLine("Message: " + e.Message);
                Console.WriteLine(e);
                //throw;
            }
            Console.ReadLine();
        }
    }
}
