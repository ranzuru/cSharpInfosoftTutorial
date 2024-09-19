using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial.async_await_task
{
    class Other
    {
        public static async Task CompleteOtherCookingAsynchronously()
        {
            Console.WriteLine("Other: Adding Seasonings...");
            Console.WriteLine("Other: Tasting for salt...");
            Console.WriteLine("Other: Cooking for 5 seconds");

            await Task.Delay(5000);
            Console.WriteLine("Done cooking!");
        }
    }
}
