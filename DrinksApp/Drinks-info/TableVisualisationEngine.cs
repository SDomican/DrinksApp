using ConsoleTableExt;
using System.Diagnostics.CodeAnalysis;

namespace DrinksApp.Drinks_info
{
    internal class TableVisualisationEngine
    {

        public static void ShowTable<T>(List<T> tableData, [AllowNull] string tableName) where T : class
        {


            if (tableName == null)
                tableName = "";

            Console.WriteLine("\n\n");

            ConsoleTableBuilder.From(tableData)
                .WithColumn(tableName)
                .ExportAndWriteLine();

            Console.WriteLine("\n\n");

        }

    }


}
