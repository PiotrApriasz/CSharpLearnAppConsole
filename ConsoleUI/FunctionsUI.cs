using Spectre.Console;

namespace ConsoleUI
{
    public static class FunctionsUI
    {
        /// <summary>
        /// Creates look and functionality of screen with sign in and sing up
        /// </summary>
        internal static void HelloScreen()
        {
           ElementsUI.ScreenTop();
           
           var choice = AnsiConsole.Prompt(
               new SelectionPrompt<string>()
                   .Title("Welcome in my app!\n[Red]Sign in[/] or [Red]Sign up[/] if you are new user")
                   .PageSize(3)
                   .AddChoice("Sign in")
                   .AddChoice("Sign up")
                   );
        }

        internal static void SignUp()
        {
            
        }
    }
}