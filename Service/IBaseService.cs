using System.Collections.Generic;

namespace brane.Service
{
    public interface IBaseService<T> where T : class
    {
        T GetOne(int id);
        List<T> GetIn();
        List<T> GetAll();

        void Add(T item);
        void Edit(T item);
        void Delete(int id);
    }
}