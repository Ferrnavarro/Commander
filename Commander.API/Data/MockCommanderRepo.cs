using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Commander.API.Models;

namespace Commander.API.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil and egg", Line = "Boil water", Platform = "Kettle & Pan" },
                new Command { Id = 1, HowTo = "Cut bread", Line = "Get a Knife", Platform = "Knife & chopping board" },
                new Command { Id = 2, HowTo = "Make cup of tea", Line = "Place teabag in cup", Platform = "Kettle & cup" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil and egg", Line = "Boil water", Platform = "Kettle & Pan" };
        }
    }
}
