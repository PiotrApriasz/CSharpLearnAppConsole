using System;
using System.Text.RegularExpressions;
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
            var username = GetUsername();

            Console.Clear();
            ElementsUI.ScreenTop();

            // Get password
            var password = GetPassword();
            
            // Get user's name
            Console.Clear();
            ElementsUI.ScreenTop();
            
            var name = AnsiConsole.Ask<string>("Enter your [green]name[/]");
            
            // Get user's last name
            Console.Clear();
            ElementsUI.ScreenTop();
            
            var lastName = AnsiConsole.Ask<string>("Enter your [green]last name[/]");
            
            // Get user's email
            Console.Clear();
            ElementsUI.ScreenTop();

            var email = GetEmail();
        }

        #region SignUp functions

        /// <summary>
        /// Get email from user
        /// </summary>
        /// <returns></returns>
        private static string GetEmail()
        {
            string email;
            while (true)
            {
                email = AnsiConsole.Ask<string>("Enter your [green]email[/]");

                if (!Regex.IsMatch(email,
                    @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                {
                    Console.Clear();
                    ElementsUI.ScreenTop();
                    AnsiConsole.Markup($"[underline red]Incorrect email!\n\n[/]");
                }
                else break;
            }

            return email;
        }

        /// <summary>
        /// Get password from user
        /// </summary>
        /// <returns></returns>
        private static string GetPassword()
        {
            string password;
            while (true)
            {
                password = AnsiConsole.Prompt(
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

            return password;
        }

        /// <summary>
        /// Get username from user
        /// </summary>
        /// <returns></returns>
        private static string GetUsername()
        {
            string username;
            while (true)
            {
                username = AnsiConsole.Ask<string>("Enter your [green]username[/]");

                if (RegisterService.IsLoginSameAsRegisteredBefore(username))
                {
                    Console.Clear();
                    ElementsUI.ScreenTop();
                    AnsiConsole.Markup($"[underline red]Login {username} already exists!\n\n[/]");
                }
                else break;
            }

            return username;
        }

        #endregion
    }
}