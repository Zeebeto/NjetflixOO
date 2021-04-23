using System;
using System.Collections.Generic;

namespace NjetflixOO
{
    public class Commandhandler
    {
        public Boolean running = true;
        // private Command[] _cmds;
        private static readonly List<Command> _cmds = new List<Command>();
        private List<string> temp = new List<string>();

        public Commandhandler()
        {
            _cmds.Add(new Command("help", helpcmd()));
            _cmds.Add(new Command("return", "returning movie..."));
            _cmds.Add(new Command("list", listMovies(Store.getUnrentedlist())));
            // _cmds = new List<Command>()
            // {
            //     new Command("help", helpcmd()),
            //     new Command("return", "returning movie..."),
            //     new Command("list", listMovies(Store.getUnrentedlist()))
            // };
        }
        
        private string helpcmd()
        {
           string print = string.Empty;
           // string print = $"{_cmds.Count}";
            // for (int i = 0; i < _cmds.Count; i++)
            // {
            //     Console.WriteLine(_cmds[i].name);
            // }
            // for (int i = 0; i < _cmds.Length; i++)
            // {
            //     cmdlist.Add($"added");
            // }
            // foreach (var cmd in _cmds)
            // {
            //     print += $"{cmd.name}\n";
            // }
            // Console.WriteLine(_cmds.Count);
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