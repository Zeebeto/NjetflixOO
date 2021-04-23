using System;
using System.Collections.Generic;

namespace NjetflixOO
{
    class Program
    {
        static void Main()
        {
            var avengers1 = new Movies("The Avengers", 2012, 144, 99, "Joss Wheaton", "Adventure");
            var avatar = new Movies("Avatar", 2012, 240, 59, "Steven Speilberg", "Scifi");
            var Cashregister = new Cashregister();
            var store = new Store(avatar, avengers1);
            store.welcome();
            var command = new Commandhandler();
            while (command.running)
            {
                var input = Console.ReadLine();
                Console.WriteLine( command.handlecmd(input.ToLower()));
            }
        }
    }
}
/*
             *classes:
             *customer - member status
             *movie
             *store - movies in stock
             *command handler
             *cash register
             * 
             */