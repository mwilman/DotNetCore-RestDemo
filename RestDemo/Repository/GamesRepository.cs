using System.Collections.Generic;
using System.Linq;
using Data.Context;
using Data.Entities;

namespace RestDemo.Controllers
{
    public class GamesRepository: IRepository<Game>
    {
        private readonly ApplicationContext _context;

        public GamesRepository(ApplicationContext context)
        {
            _context = context;
        }
        public void Insert(Game element)
        {
            _context.Games.Add(element);
        }

        public void Delete(Game element)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Game element)
        {
            throw new System.NotImplementedException();
        }

        public Game GetById(int id)
        {
            throw new System.NotImplementedException();
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