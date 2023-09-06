using ConsoleTableExt;
using DrnksApiHttpClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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

            string url = "https://www.thecocktaildb.com/api/json/v1/1/filter.php?c=" + category.Replace(" ", "_");

            await using Stream stream = await client.GetStreamAsync(url);

            List<Drink> fullDrinkList = new List<Drink>();

            var drinkRepositories = await JsonSerializer.DeserializeAsync<DrinksCategoryRepository>(stream);

            foreach (Drink drinkCategory in drinkRepositories.drinkCategories)
            {
                fullDrinkList.Add(drinkCategory);
            }

            ConsoleTableBuilder
            .From(fullDrinkList)
            .ExportAndWriteLine();
        }

    }
}
