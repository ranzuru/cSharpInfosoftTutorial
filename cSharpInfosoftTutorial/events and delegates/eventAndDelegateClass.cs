using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial.events_and_delegates
{
    class eventAndDelegateClass
    {
        public delegate int MyDel(int str);
        public event MyDel myEvent;
        public static void Main()
        {
            try
            {
                Console.WriteLine("Check Your Lucky Number Today!");
                Console.WriteLine("=================================================");
                Console.Write("Entry (numeric 1 - 100): ");

                int num = Convert.ToInt32(Console.ReadLine());
                EventProgram obj1 = new EventProgram();
                int result = obj1.MyEvent(num);

                if (result == num) Console.WriteLine("\nYour luck is in the air today—seize the moment!");
                else  Console.WriteLine("\nIt seems luck is taking a break today, but keep pushing forward!");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid entry, it must be numeric (whole number/s)");
            }
        }
        class EventProgram
        {
            public EventProgram()
            {
                this.MyEvent += new MyDel(this.Randomizer);
            }
            public MyDel MyEvent { get; set; }

            public int Randomizer(int result)
            {
                Random rnd = new Random();
                result = rnd.Next(1, 101);
                return result;
            }
        }
    }
}
