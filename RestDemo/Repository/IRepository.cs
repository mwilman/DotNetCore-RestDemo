using System.Collections.Generic;

namespace RestDemo.Repository
{
    public interface IRepository<T>
    {
        T Insert(T element);
        void Delete(T element);
        void Update(T element);
        T GetById(int id);
        void Save();
        IEnumerable<T>GetAll();
    }
}