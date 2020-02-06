using System.Collections.Generic;
using System.Linq;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace RestDemo.Controllers
{
    [ApiController]
    [Route("games")]
    public class GamesController: ControllerBase
    {
        private readonly GamesRepository _gamesRepository;
        public GamesController(GamesRepository _gamesRepository)
        {
            this._gamesRepository = _gamesRepository;
        }
        
        [HttpGet]
        public IList<Game> GetAllGames()
        {
            return _gamesRepository.GetAll().ToList();
        }
    }
}