using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DrnksApiHttpClient
{
    internal record DrinksRepository
    {
        [JsonPropertyName("drinks")]
        public DrinksCategory[] drinkCategories { get; set; }
    }

    internal record DrinksCategory
    {
        [JsonPropertyName("strCategory")]
        public String drinkCategory { get; set; }
    }

    internal record Drink
    {
        [JsonPropertyName("strCategory")]
        public String drinkCategory { get; set; }

        [JsonPropertyName("idDrink")]
        public int idCategory { get; set; }
    }
}
