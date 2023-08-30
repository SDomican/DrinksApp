using DrinksApp.Drinks_info;

namespace DrinksApp
{
    public class UserInput
    {

        DrinksService drinksService = new();

        internal void GetCategoriesInput()
        {
            drinksService.GetCategories();

            Console.WriteLine("Choose category");

            string category = Console.ReadLine();

            while (!Validator.IsStringValid(category))
            {
                Console.WriteLine("\nInvalid Category");
                category = Console.ReadLine();
            }

            GetDrinksInput(category);
        }

        private void GetDrinksInput(string category)
        {
            drinksService.GetDrinksByCategory(category);
        }
    }
}
