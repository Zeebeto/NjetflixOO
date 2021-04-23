using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace NjetflixOO
{
    public class Commandhandler
    {
        public Boolean running = true;
        private Command[] _cmds;
        
        public Commandhandler()
        {
            _cmds = new Command []
            {
                new Command("help", ""),
                new Command("return", "returning movie..."),
                new Command("list", listMovies(Store.getUnrentedlist())),
                new Command("test", ""),
                new Command("test2", ""),
                new Command("test3", ""),
                new Command("test4", ""),
            };
            Command.setCmdtodo(_cmds);
        }
        
        public static string helpcmd(Command[] commands)
        {
           string print = string.Empty;
           foreach (var cmd in commands)
           {
               print += $"{cmd.name}\n";
           }
           return print;
        }
        private string listMovies(List<Movies> unrented)
        {
            string print = String.Empty;
            foreach (var film in unrented)
            {
                print += $"{film.Title}\n";
            }
            return print;
        }
        
        private Command Findcmd(string cmdname)
        {
            foreach (var cmd in _cmds)
            {
                if (cmd.name == cmdname)
                {
                    return cmd;
                }
            }
            return null;
        }
        public string handlecmd(string cmdname)
        {
            var cmd = Findcmd(cmdname);
            return cmd == null ? $"{cmdname} is not recognized." : cmd.todo;
        }
    }
}