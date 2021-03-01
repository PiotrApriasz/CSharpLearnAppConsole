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
            Console.Clear();
            ElementsUI.ScreenTop();
            
            AnsiConsole.Markup($"Hello [green]{User.Name}![/]\n");

            var choice = FunctionsUI.MainScreen();
        }

        #endregion
    }
}