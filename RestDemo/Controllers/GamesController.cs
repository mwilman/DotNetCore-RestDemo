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
        public GamesController(IRepository<Game> gamesRepository)
        {
            _gamesRepository = gamesRepository;
        }
        
        [HttpGet]
        public IActionResult GetAllGames()
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

            return Ok(ausgabe);
        }

        [HttpPost]
        public IActionResult AddGame(CreateGameDto createGame)
        {
            Game game = new Game
            {
                Name = createGame.Name
            };

            var result = _gamesRepository.Insert(game);
            _gamesRepository.Save();
            return Ok(result);
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult GetGameById(int id)
        {
            var result = _gamesRepository.GetById(id);
            return Ok(
                new GameDto
                {
                    Name = result.Name
                }
            );
        }

        [Route("{id}")]
        [HttpPut]
        public IActionResult UpdateGameById(int id, GameDto game)
        {
            var entity = _gamesRepository.GetById(id);
            entity.Name = game.Name;
            _gamesRepository.Save();
            return Ok(entity);
        }

        [Route("{id}")]
        [HttpDelete]
        public IActionResult UpdateGameById(int id)
        {
             _gamesRepository.Delete(id);
            _gamesRepository.Save();
            return NoContent();
        }
    }
}