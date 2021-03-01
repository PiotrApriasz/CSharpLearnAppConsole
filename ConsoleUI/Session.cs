using System;
using ApplicationCore;

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

        

        #endregion
    }
}