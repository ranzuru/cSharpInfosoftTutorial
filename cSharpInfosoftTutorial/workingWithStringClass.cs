using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial
{
    class workingWithStringClass
    {
        public static void Main()
        {
            string text = "Sample Text";

            Console.WriteLine("text with single and double qoutation            : \'" + text + "\"");
            Console.WriteLine("text with slash                                  : \\" + text + "/");
            Console.WriteLine("text length                                      : " + text.Length);
            Console.WriteLine("text with all upper case                         : " + text.ToUpper());
            Console.WriteLine("text with all lower case                         : " + text.ToLower());
            Console.WriteLine("does the text contains word \"Sample\"             : " + text.Contains("Sample"));
            Console.WriteLine("does the text contains letter \"z\"                : " + text.Contains("z"));
            Console.WriteLine("what letter is in index 7                        : " + text[7]);
            Console.WriteLine("what index does it start on the \"ext\" in \"Text\"  : " + text.IndexOf("ext"));
            Console.WriteLine("only print the word \"Text\"                       : " + text.Substring(7));
            Console.WriteLine("only print the word \"amp\" in \"Sample\"            : " + text.Substring(1, 3));
        }
    }
}
