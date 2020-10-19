using System.Collections.Generic;
using Commander.API.Models;

namespace Commander.API.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands();

        Command GetCommandById(int id);

    }
}
