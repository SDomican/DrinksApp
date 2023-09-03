using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DrnksApiHttpClient
{
    internal class DrinksRepository
    {
        [JsonPropertyName("drinks")]
        public DrinksCategory[] drinkCategories { get; set; }
    }

    public class DrinksCategory
    {
        [JsonPropertyName("strCategory")]
        public String drinkCategory { get; set; }
    }
}
