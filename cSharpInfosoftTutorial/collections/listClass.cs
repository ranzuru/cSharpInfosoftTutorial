using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial.collections
{
    class listClass
    {
        public static void Main()
        {
            // index starts from 0
            // differs from arrays since its size is dynamic (through add/ remove) 
            // <value>, value can be a collection
            // short-hand format
            List<string> names = ["Shenzou", "Gagarin", "Dresselhaus"];
            List<string> names2 = []; // empty list
            // standard format (preferred)
            List<string> names3 = new List<string> { "sample", "name"};
            List<string> names4 = new List<string> (); // empty list
            // inserted after Dresselhaus
            names.Add("Hiawatha");
            names.Remove("Shenzou");
            int index = 0;
            // var automatically converts into a data type
            foreach (var name in names) // since names (list) is string, the var name will be string
            {
                Console.WriteLine($"List[{index}] Value: {name.ToUpper()}");
                index++;
            }
        }
    }
}
