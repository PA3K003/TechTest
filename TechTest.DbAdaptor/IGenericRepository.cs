using System.Collections.Generic;

namespace TechTest.DbAdaptor
{
    public interface IGenericRepository<T> where T : class
    {
        void Delete(object id);
        IEnumerable<T> GetAll();
        T GetById(object id);
        T Insert(T obj);         
        T Update(T obj);
    }
}