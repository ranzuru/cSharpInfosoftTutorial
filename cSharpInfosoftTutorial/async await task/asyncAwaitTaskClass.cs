using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial.async_await_task
{
    class asyncAwaitTaskClass
    {
        public static async Task Main()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            await Meal.CookMealAsynchronously();
            stopwatch.Stop();
            TimeSpan elapsed = stopwatch.Elapsed;
            Console.WriteLine($"Elapsed Time (Seconds): {elapsed.TotalSeconds} s");
            Console.ReadLine();
        }
    }
}
