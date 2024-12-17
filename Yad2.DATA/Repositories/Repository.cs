using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.CORE.Repositories;

namespace Yad2.DATA.Repositories
{
    public class Repository<T>:IRepository<T> where T : class
    {
        private readonly DataContext context1;
        protected readonly DbSet<T> _dbSet;
        public Repository(DataContext context)
        {
            context1 = context;
            _dbSet = context.Set<T>();
        }
        public T Add(T entity)
        {
            _dbSet.Add(entity);
            return entity;
        }
        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }
        public IEnumerable<T> GetAll()
        {
           context1.Products.Include(a => a.Advertiser).ToList();
            return _dbSet.ToList();
        }
        public T? GetById(int id) 
        {
            return _dbSet.Find(id);
        }
        public T Update(T entity)
        {
            _dbSet.Update(entity);
            return entity;
        }

    }
}
