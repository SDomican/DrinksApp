using ConsoleTableExt;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksApiHttpClient
{
    internal class TableVisualisation
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
