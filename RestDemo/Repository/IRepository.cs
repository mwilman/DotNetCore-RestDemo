using System.Collections.Generic;

namespace RestDemo.Controllers
{
    public interface IRepository<T>
    {
        void Insert(T element);
        void Delete(T element);
        void Update(T element);
        T GetById(int id);
        void Save();
        IEnumerable<T>GetAll();
    }
}