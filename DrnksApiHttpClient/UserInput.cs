using DrnksApiHttpClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksApiHttpClient
{
    public static class UserInput
    {
        
        public static async void GetInput()
        {
            DrinksService drinksService = new DrinksService();

            Console.WriteLine("Please enter a category");

            String category = Console.ReadLine();

            Console.WriteLine($"You have selected {category}.");

            await drinksService.GetDrinksByCategory(category);

        }

    }
}
