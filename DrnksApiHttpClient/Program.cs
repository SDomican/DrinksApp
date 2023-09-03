// See https://aka.ms/new-console-template for more information
using DrnksApiHttpClient;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Text.Json;
using ConsoleTableExt;

using HttpClient client = new();
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(
    new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

await ProcessRepositoriesAsync(client);

static async Task ProcessRepositoriesAsync(HttpClient client)
{

    await using Stream stream =
    await client.GetStreamAsync("https://www.thecocktaildb.com/api/json/v1/1/list.php?c=list");

    var repositories =
        await JsonSerializer.DeserializeAsync<DrinksRepository>(stream);

    foreach (DrinksCategory category in repositories.drinkCategories)
    {
        Console.WriteLine(category.drinkCategory);
    }

}
