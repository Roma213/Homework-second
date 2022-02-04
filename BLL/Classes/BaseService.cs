using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using BLL.Interfaces;
using Domain;

namespace BLL.Classes
{
    public class BaseService<T> : IBaseService<T> where T: class
    {
        private readonly ApplicationContext _context;
        public BaseService()
        {
            _context = new ApplicationContext();
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public IEnumerable<T> GetMany(Expression<Func<T, bool>> filter = null)
        {
            return filter == null ? _context.Set<T>() : _context.Set<T>().Where(filter);
        }

        public T Get(Expression<Func<T, bool>> filter = null)
        {
            return filter == null ? _context.Set<T>().FirstOrDefault() : _context.Set<T>().FirstOrDefault(filter);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
