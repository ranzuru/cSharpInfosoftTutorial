using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial.polymorphism
{
    class polymorphismMainClass
    {
        public static void Main()
        {
            Kriegsmarine bismarck = new Battleships();
            Kriegsmarine grafZeppelin = new derivedClass.AircraftCarrier();
            // overrides the armament method from kriegsmarine (base class) from derived class
            Console.WriteLine("Kriegsmarine Ship Information");
            Console.WriteLine("========================================\n");
            bismarck.armament();
            Console.WriteLine("\n");
            grafZeppelin.armament();
        }
    }

    class Kriegsmarine()
    {
        // virtual modifier allows the method (base class) to be overridden as as indicate it that it can be overridden
        virtual public void armament()
        {
            Console.WriteLine("Secondary Armament #1: 105 mm/65 SK C/33 on a Dop. L. C/31 mount");
        }
    }

    class Battleships : Kriegsmarine
    {
        // override modifier allows the method (derived class) to override the indicated method from base class
        override public void armament()
        {
            Console.WriteLine("Name           : BISMARCK");
            Console.WriteLine("Class          : Battleship");
            Console.WriteLine("Captain        : Ernst Lindemann");
            Console.WriteLine("Armaments");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Main Battery   : 380 mm/52 SK C/34 on a Drh LC/34 mount");
        }
    }
}
