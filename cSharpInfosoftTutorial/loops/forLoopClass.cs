using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial.loops
{
    class forLoopClass
    {
        public static void Main()
        {
            string[] userName = { "johnrancelb26", "j.batulan", "ranc333l" };
            string[] password = { "SweetTooth33", "GlibPayment22", "5ff5r" };

            Console.WriteLine("User Account Authentication utilizing Array");
            Console.Write("\nUsername: ");
            string userNameInput = Console.ReadLine();
            Console.Write("Password: ");
            string passwordInput = Console.ReadLine();

            bool isFoundUserName = false;
            bool isFoundPassword = false;

            if (userNameInput == "" && passwordInput == "")
            {
                Console.WriteLine("\nUsername and Password must not be empty");
            }
            else if (userNameInput == "" || passwordInput == "")
            {
                Console.WriteLine("\nUsername/ Password must not be empty");
            }
            else
            {
                for (int i = 0; i < userName.Length; i++)
                {
                    if (userNameInput == userName[i] && !passwordInput.Equals(password[i]))
                    {
                        Console.WriteLine("\nUser Account Mismatch!");
                        isFoundUserName = true;
                        isFoundPassword = false;
                    }

                    if (userNameInput == userName[i] && passwordInput.Equals(password[i]))
                    {
                        Console.WriteLine("\nAuthentication Success!");
                        isFoundUserName = true;
                        isFoundPassword = true;
                    }
                }

                if (!isFoundUserName && !isFoundPassword) Console.WriteLine("\nUser Account Not Found!");
            }
        }
    }
}
