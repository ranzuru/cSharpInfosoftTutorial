using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial.polymorphism
{
    class AircraftCarrier : Kriegsmarine
    {
        override public void armament()
        {
            Console.WriteLine("Name           : GRAF ZEPPELIN");
            Console.WriteLine("Class          : Aircraft Carrier");
            Console.WriteLine("Captain        : Hugo Eckener");
            Console.WriteLine("Armaments");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Attack Aircraft   : Me 155A");
            Console.WriteLine("Torpedo Bombers   : Ta 152C-1/R14");
            Console.WriteLine("Bombers           : Ta 152C-1/R14");
        }
    }
}
