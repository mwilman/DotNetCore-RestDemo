using System.Collections.Generic;
using System.Linq;
using AutoMapper;
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
        private readonly IMapper _mapper;
        public GamesController(IRepository<Game> gamesRepository, IMapper mapper)
        {
            _gamesRepository = gamesRepository;
            _mapper = mapper;
        }
        
        [HttpGet]
        public IActionResult GetAllGames()
        {
            List<Game> liste = _gamesRepository.GetAll().ToList();

            return Ok(_mapper.Map<IEnumerable<GameDto>>(liste));
        }

        [HttpPost]
        public IActionResult AddGame(CreateGameDto createGame)
        {
            Game game = _mapper.Map<Game>(createGame);

            Game result = _gamesRepository.Insert(game);
            _gamesRepository.Save();
            return Ok(result);
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult GetGameById(int id)
        {
            Game result = _gamesRepository.GetById(id);
            return Ok(_mapper.Map<GameDto>(result));
        }

        [Route("{id}")]
        [HttpPut]
        public IActionResult UpdateGameById(int id, GameDto game)
        {
            Game entity = _gamesRepository.GetById(id);
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