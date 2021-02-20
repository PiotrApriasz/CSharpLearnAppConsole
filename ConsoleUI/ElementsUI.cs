using System;
using Spectre.Console;

namespace ConsoleUI
{
    public static class ElementsUI
    {
        internal static void LineUp()
        {
            var rule = new Rule("[silver]C# Learn Path App[/]");
            AnsiConsole.Render(rule);
        }

        internal static void LineDown()
        {
            var rule = new Rule();
            AnsiConsole.Render(rule);
        }
    }
}