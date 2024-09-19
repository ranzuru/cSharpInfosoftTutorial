using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial.async_await_task
{
    class Water
    {
        public static async Task BoilWaterAsynchronously()
        {
            Console.WriteLine("Water: Boiling water...");
            await Task.Delay(3000); // Simulating an asynchronous task
            Console.WriteLine("Water: Water is hot!");
        }
    }
}
