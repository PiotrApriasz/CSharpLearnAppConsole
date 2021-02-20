﻿using System;
using System.Net.Mime;
using DataAccess;
using Spectre.Console;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var choice = FunctionsUI.HelloScreen();

                switch (choice)
                {
                    case "Sign in":
                        break;
                    case "Sign up":
                        RegisterService.SignUp(FunctionsUI.SignUp());
                        break;
                    case "Exit":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
            
        }
    }
}