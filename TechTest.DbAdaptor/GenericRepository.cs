using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTest.DAL;

namespace TechTest.DbAdaptor
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private EmployeeDbContext _context = null;
        private DbSet<T> table = null;

        public GenericRepository()
        {
            this._context = new EmployeeDbContext();
            table = _context.Set<T>();
        }

        public GenericRepository(EmployeeDbContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            List<T> list = table.ToList();
            return list as IEnumerable<T>;
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public T Insert(T obj)
        {
            table.Add(obj);
            _context.SaveChanges();
            return obj;
        }

        public T Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
            return obj;
        }

        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
            _context.SaveChanges();
        }

      
        //private bool disposed = false;
        //protected virtual void Dispose(bool disposing)
        //{
        //    if (!this.disposed)
        //    {
        //        if (disposing)
        //        {
        //            _context.Dispose();
        //        }
        //    }
        //    this.disposed = true;
        //}
        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}

    }
}

