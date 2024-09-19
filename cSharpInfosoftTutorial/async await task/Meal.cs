using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpInfosoftTutorial.async_await_task
{
     class Meal
    {
        public static async Task CookMealAsynchronously()
        {
            Console.WriteLine("Meal: Cooking meal asynchronously...");

            // concurrently perform tasks
            Task boilWaterTask = Water.BoilWaterAsynchronously();
            Task cutVegetablesTask = Vegetables.CutVegetablesAsynchronously();

            // Await the completion of both tasks
            await Task.WhenAll(boilWaterTask, cutVegetablesTask);

            await Other.CompleteOtherCookingAsynchronously();
        }
    }
}
