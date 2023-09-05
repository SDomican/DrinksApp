using DrnksApiHttpClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace DrinksApiHttpClient
{
    internal class DrinksService
    {

        public async Task GetDrinksByCategory(String category)
        {

            using HttpClient client = new();
            client.DefaultRequestHeaders.Accept.Clear();

            await using Stream stream = await client.GetStreamAsync("https://www.thecocktaildb.com/api/json/v1/1/filter.php?c=Ordinary_Drink");

            List<Drink> drinksList = new List<Drink>();

            var drinkRepositories =
    await JsonSerializer.DeserializeAsync<DrinksRepository>(stream);

            Console.WriteLine(drinkRepositories.GetType());
        }

    }
}
