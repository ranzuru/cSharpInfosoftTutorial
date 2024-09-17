using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial.encapsulation
{
    class encapsulationMainClass
    {
        public static void Main()
        {
            // SET
            characterTraits character1 = new characterTraits(90,81,85,79,87,70);
            string name = "Scipio Africanus";
            // GET
            Console.WriteLine("CHARACTER TRAITS ==================================");
            Console.WriteLine("Name        : " + name);
            Console.WriteLine("Strength    : " + character1.Str);
            Console.WriteLine("Dexterity   : " + character1.Dex);
            Console.WriteLine("Intelligence: " + character1.Intl);
            Console.WriteLine("Charisma    : " + character1.Charisma);
            Console.WriteLine("Constitution: " + character1.Constitution);
            Console.WriteLine("Wisdom      : " + character1.Wisdom);
        }
    }
}
