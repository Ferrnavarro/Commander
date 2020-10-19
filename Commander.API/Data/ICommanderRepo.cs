using System.Collections.Generic;
using Commander.API.Models;

namespace Commander.API.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges();

        IEnumerable<Command> GetAllCommands();

        Command GetCommandById(int id);

        void CreateCommand(Command command);

        void UpdateCommand(Command command);

    }
}
