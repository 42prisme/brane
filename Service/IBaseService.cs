using System.Collections.Generic;
using brane.Models;

namespace brane.Service
{
    public interface IBaseService<T> where T : class
    {
        T GetOne(int id);
        List<T> GetIn();
        List<T> GetAll(int id = 0);

        void Add(T item);
        void Edit(T item);
        void Delete(T item);
    }
}