using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace RestDemo.Controllers
{
    [ApiController]
    [Route("games")]
    public class GamesController
    {
        private static readonly string[] games = {"Tetris", "Mario"};
        
        [HttpGet]
        public IEnumerable<string> GetAllGames()
        {
            return games;
        }
    }
}