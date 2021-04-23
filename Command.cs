using System.Collections.Generic;

namespace NjetflixOO
{
    public class Command
    {
        public string name { get; }
        public string todo { get; set; }

        public Command(string name, string todo)
        {
            this.name = name;
            this.todo = todo;
        }

        public static void setCmdtodo(Command[] cmds)
        {
            cmds[0].todo = Commandhandler.helpcmd(cmds);
            cmds[4].todo = Commandhandler.helpcmd(cmds);
            
        }
    }
}