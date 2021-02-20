using System;
using DataAccess;
using Spectre.Console;

namespace ConsoleUI
{
    public static class FunctionsUI
    {
        /// <summary>
        /// Creates look and functionality of screen with sign in and sing up
        /// </summary>
        internal static string HelloScreen()
        {
            Console.Clear();
            ElementsUI.ScreenTop();
           
           var choice = AnsiConsole.Prompt(
               new SelectionPrompt<string>()
                   .Title("Welcome in my app!\n[Red]Sign in[/] or [Red]Sign up[/] if you are new user")
                   .PageSize(4)
                   .AddChoice("Sign in")
                   .AddChoice("Sign up")
                   .AddChoice("Exit")
                   );
           return choice;
        }

        /// <summary>
        /// Creates look and functionality to perform sign up
        /// </summary>
        internal static void SignUp()
        {
            Console.Clear();
            ElementsUI.ScreenTop();
            
            // Get username
            while (true)
            {
                var username = AnsiConsole.Ask<string>("Enter your [green]username[/]");

                if (RegisterService.IsLoginSameAsRegisteredBefore(username))
                {
                    Console.Clear();
                    ElementsUI.ScreenTop();
                    AnsiConsole.Markup($"[underline red]Login {username} already exists!\n\n[/]");
                }
                else break;
            }

            Console.Clear();
            ElementsUI.ScreenTop();

            // Get password
            while (true)
            {
                var password = AnsiConsole.Prompt(
                    new TextPrompt<string>("Enter [green]password[/]").Secret());

                Console.WriteLine();
                Console.WriteLine();
                
                var passwordAgain = AnsiConsole.Prompt(
                    new TextPrompt<string>("Enter [green]password[/] again").Secret());

                if (password != passwordAgain)
                {
                    Console.Clear();
                    ElementsUI.ScreenTop();
                    AnsiConsole.Markup($"[underline red]Passwords are different!\n\n[/]");
                }
                else break;
            }
            
            Console.Clear();
            ElementsUI.ScreenTop();
            
            var name = AnsiConsole.Ask<string>("Enter your [green]name[/]");
            
            Console.Clear();
            ElementsUI.ScreenTop();
            
            var lastName = AnsiConsole.Ask<string>("Enter your [green]last name[/]");
        }
    }
}