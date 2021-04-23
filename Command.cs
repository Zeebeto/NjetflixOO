using System.Collections.Generic;

namespace NjetflixOO
{
    public class Command
    {
        public string name { get; }
        public string todo { get; }
        public Command(string name, string todo)
        {
            this.name = name;
            this.todo = todo;
        }
    }
}