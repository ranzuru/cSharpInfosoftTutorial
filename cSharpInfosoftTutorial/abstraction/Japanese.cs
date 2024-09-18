using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial.abstraction
{
    class Japanese : Vehicles
    {
        public Japanese(string type) : base(type)
        {
            Console.WriteLine("Type: " + type);
        }
        public override void Aviation()
        {
            Console.WriteLine("Vehicle: Mitsubishi A6M \"Zero\"");
        }

    }
}
