using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.CORE.Models;
using Yad2.CORE.Repositories;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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
        public async Task<T> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            return entity;
        }
        public async Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);  
            await Task.CompletedTask; 
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
           context1.Products.Include(a => a.Advertiser).Include(a => a.Customer).ToList();
           context1.Customers.Include(a => a.Products).ToList();
           context1.Advertisers.Include(a => a.products).ToList();
            var res = await _dbSet.ToListAsync();
            return res;
        }
        public async Task<T?> GetByIdAsync(int id) 
        {
            context1.Products.Include(a => a.Advertiser).FirstOrDefault(p=>p.Id==id);
            context1.Customers.Include(a => a.Products).FirstOrDefault(p => p.Id == id);
            context1.Advertisers.Include(a => a.products).FirstOrDefault(p => p.Id == id);
            var res=await _dbSet.FirstOrDefaultAsync(p => EF.Property<int>(p, "Id") == id);
            return res;
        }
        public T Update(T entity)
        {
            _dbSet.Update(entity);
            return entity;
        }

    }
}
