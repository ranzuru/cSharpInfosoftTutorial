using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial.async_await_task
{
    class Vegetables
    {
        public static async Task CutVegetablesAsynchronously()
        {
            Console.WriteLine("Veg: Chopping vegetables...");
            await Task.Delay(3000); // Simulating an asynchronous task
            Console.WriteLine("Veg: Vegetables are ready!");
        }
    }
}
