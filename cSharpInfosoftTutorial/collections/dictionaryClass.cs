using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial.collections
{
    class dictionaryClass
    {
        public static void Main()
        {
            // <key, value>, value can be a collection
            // must be different key but can be the same value

            // short format
            Dictionary<int, string> dict = new(); // empty dictionary
            Dictionary<int, string> dict2 = new()
            {   
                {1, "Dog"},
                {2, "Cat"},
                {3, "Cat"}
            };
            // standard format
            Dictionary<int, string> dict3 = new Dictionary<int, string>(); // empty dictionary
            Dictionary<int, string> dict4 = new Dictionary<int, string>
            {
                {1, "Dog"},
                {2, "Cat"},
                {3, "Cat"}
            };

            dict4.Add(4, "Pig");
            // remove using key instead of value or both
            dict4.Remove(1);

            foreach (KeyValuePair<int, string> element in dict4)
            {
                // 0 for key, 1 for value
                Console.WriteLine("Key: {0} and Value: {1}", element.Key, element.Value);
            }
        }
    }
}
