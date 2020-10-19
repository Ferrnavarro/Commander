using System.Collections;
using System.Collections.Generic;
using Commander.API.Data;
using Commander.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.API.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        public CommandsController()
        {
            
        }

        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commands = _repository.GetAllCommands();

            return Ok(commands);
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var command = _repository.GetCommandById(id);

            return Ok(command);
        }
    }
}
