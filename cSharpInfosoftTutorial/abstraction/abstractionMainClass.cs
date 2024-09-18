using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial.abstraction
{
    // hides certain details, but shows important information
    class abstractionMainClass
    {
        public static void Main()
        {
            // abstract base class with abstract method
            Vehicles german = new Germany("Aviation");
            Console.WriteLine("==============================================");
            german.Aviation();
            Console.WriteLine("\n");
            // abstract base class without abstract method (not overriden)
            Germany german2 = new Germany("Ground");
            Console.WriteLine("==============================================");
            german2.Ground();
            Console.WriteLine("\n");
            // base class
            Vehicles general = new Germany("Ground");
            Console.WriteLine("==============================================");
            general.Ground();
            Console.WriteLine("\n");
            // abstract base class with abstract method
            Vehicles japanese = new Japanese("Aviation");
            Console.WriteLine("==============================================");
            japanese.Aviation();
        }
    }
    // abstract class cannot be instantiated (by itlsef)
    abstract class Vehicles
    {
        string type { get; set; }
        public Vehicles(string type)
        {
            this.type = type;
        }

        // can add parameters inside
        // can also add non-abstract method/s 
        // abstract method can only be declared inside an abstract class
        /*
         * abstraction is overriding base class method/s with no implementation but only declaring it.
         * the derived class/es will do the implementation, 
         * which is like skipping or removing the default implementaion (implementation from base class method/s)
         */
        public abstract void Aviation();
        public void Ground()
        {
            Console.WriteLine("Vehicle: Tank");
        }
    }
    class Germany : Vehicles
    {
        public Germany(string type) : base(type)
        {
            Console.WriteLine("Type: " + type);
        }
        /*
         * abstract method inside the base class should have the override method inside of each inheriting derived 
         * class/es. Example below.
         */
        public override void Aviation()
        {
            Console.WriteLine("Vehicle: Messerschmitt Bf 109");
        }
        public void Ground()
        {
            Console.WriteLine("Vehicle: Flakpanzer IV \"Kugelblitz\"");
        }
    }
}
