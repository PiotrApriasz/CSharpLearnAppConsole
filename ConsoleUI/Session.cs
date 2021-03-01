using System;
using ApplicationCore;
using Spectre.Console;

namespace ConsoleUI
{
    public class Session
    {
        #region Constructor

        public Session(User user)
        {
            this.User = user;
        }

        #endregion

        #region Properties

        public User User { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Functionality to make user choose what to do after sign in
        /// </summary>
        public void SelectScreen()
        {
            var work = true;
            
            while (work)
            {
                Console.Clear();
                ElementsUI.ScreenTop();
            
                AnsiConsole.Markup($"Hello [green]{User.Name}![/]\n");

                var choice = FunctionsUI.MainScreen();

                switch (choice)
                {
                    case "Learn Path":
                        Console.WriteLine("Here will be page with learn paths");
                        Console.ReadKey();
                        break;
                    case "Notes":
                        Console.WriteLine("Here will be page with learn paths");
                        Console.ReadKey();
                        break;
                    case "TO DO":
                        Console.WriteLine("Here will be page to do things");
                        Console.ReadKey();
                        break;
                    case "Log out":
                        work = false;
                        break;
                }
            }
        }

        #endregion
    }
}