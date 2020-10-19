using AutoMapper;
using Commander.API.Dtos;
using Commander.API.Models;

namespace Commander.API.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<Command, CommandReadDto>();
        }
    }
}
