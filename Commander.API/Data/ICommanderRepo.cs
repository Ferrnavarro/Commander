using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Commander.API.Models;

namespace Commander.API.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands();

        Command GetCommandById(int id);


    }
}
