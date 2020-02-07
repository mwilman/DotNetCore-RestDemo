using System.Collections.Generic;

namespace RestDemo.Repository
{
    public interface IRepository<T>
    {
        T Insert(T element);
        void Delete(int id);
        void Update(T element);
        T GetById(int id);
        void Save();
        IEnumerable<T>GetAll();
    }
}