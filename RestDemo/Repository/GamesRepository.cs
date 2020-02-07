using System.Collections.Generic;
using System.Linq;
using Data.Context;
using Data.Entities;

namespace RestDemo.Repository
{
    public class GamesRepository: IRepository<Game>
    {
        private readonly ApplicationContext _context;

        public GamesRepository(ApplicationContext context)
        {
            _context = context;
        }
        public Game Insert(Game element)
        {
            return _context.Games.Add(element).Entity;
        }

        public void Delete(int id)
        {
            var element = _context.Games.FirstOrDefault(element => element.ID == id);
            _context.Games.Remove(element);
        }

        public void Update(Game element)
        {
            throw new System.NotImplementedException();
        }

        public Game GetById(int id)
        {
            return _context.Games.FirstOrDefault(element => element.ID == id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public IEnumerable<Game> GetAll()
        {
            return _context.Games.ToList();
        }
    }
}