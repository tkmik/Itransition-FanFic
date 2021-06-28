using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.GenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(object id);
        void Add(T item);
        void Update(T item);
        void Delete(object id);
    }
}
