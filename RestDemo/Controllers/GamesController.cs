using System.Collections.Generic;
using System.Linq;
using Data.Entities;
using Data.Model;
using Microsoft.AspNetCore.Mvc;
using RestDemo.Repository;

namespace RestDemo.Controllers
{
    [ApiController]
    [Route("games")]
    public class GamesController: ControllerBase
    {
        private readonly IRepository<Game> _gamesRepository;
        public GamesController(IRepository<Game> _gamesRepository)
        {
            this._gamesRepository = _gamesRepository;
        }
        
        [HttpGet]
        public IList<GameDto> GetAllGames()
        {
            var liste = _gamesRepository.GetAll().ToList();
            var ausgabe = new List<GameDto>();
            foreach (Game game in liste)
            {
                    ausgabe.Add(new GameDto
                    {
                        Name = game.Name
                    }
                );
            }

            return ausgabe;
        }

        [HttpPost]
        public Game AddGame(CreateGameDto createGame)
        {
            Game game = new Game
            {
                Name = createGame.Name
            };

            var result = _gamesRepository.Insert(game);
            _gamesRepository.Save();
            return result;
        }
    }
}