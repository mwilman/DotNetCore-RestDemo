using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Data.Context;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace RestDemo.Controllers
{
    [ApiController]
    [Route("games")]
    public class GamesController: ControllerBase
    {
        private readonly IGamesRepository _gamesRepository;
        public GamesController(IGamesRepository _gamesRepository)
        {
            this._gamesRepository = _gamesRepository;
        }
        
        [HttpGet]
        public IList<Game> GetAllGames()
        {
            return _gamesRepository.Games.ToList();
        }
    }
}