using System;
using System.Threading.Tasks;
using Spectre.Console;

namespace ConsoleUI
{
    public static class ElementsUI
    {
        /// <summary>
        /// Creates line at the top of console screen with app title
        /// </summary>
        internal static void TitleLine()
        {
            var rule = new Rule("[silver]C# Learn Path App[/]");
            AnsiConsole.Render(rule);
        }

        /// <summary>
        /// Creates line at the bottom of console screen
        /// </summary>
        internal static void Line()
        {
            var rule = new Rule();
            AnsiConsole.Render(rule);
        }

        /// <summary>
        /// Creates look of top look of app
        /// </summary>
        internal static void ScreenTop()
        {
            Line();
            TitleLine();
            Line();
            Console.WriteLine();
        }

        /// <summary>
        /// Creates look of bottom look of app
        /// </summary>
        internal static void HelloScreenBottom()
        {
            Line();
            Line();
        }
    }
}