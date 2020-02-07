using AutoMapper;
using Data.Entities;
using Data.Model;
using RestDemo.Controllers;

namespace BusinessLogic
{
    public class GameProfile: Profile
    {
        public GameProfile()
        {
            CreateMap<Game, GameDto>();
        }
        
    }
}