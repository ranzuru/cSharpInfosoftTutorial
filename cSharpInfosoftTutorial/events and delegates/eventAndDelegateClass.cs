using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial.events_and_delegates
{
    class eventAndDelegateClass
    {
        public delegate string MyDel(string str);
        public event MyDel myEvent;
        public static void Main()
        {
            EventProgram obj1 = new EventProgram();
            string result = obj1.MyEvent("Event");
            Console.WriteLine(result);
        }
        class EventProgram
        {
            public EventProgram()
            {
                this.MyEvent += new MyDel(this.WelcomeUser);
            }
            public MyDel MyEvent { get; set; }

            public string WelcomeUser(string username)
            {
                return "Welcome " + username;
            }
        }
    }
}
