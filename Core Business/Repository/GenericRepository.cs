using LearnRepositoryPattern.DBContext;
using LearnRepositoryPattern.RepositoryInterface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnRepositoryPattern.Core_Business.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        //Add dbcontext

        protected ApplicationContext _dBContext;
        protected DbSet<T> _dbSet;
        protected ILogger _logger;

        public GenericRepository(ApplicationContext applicationContext, ILogger logger)
        {
            _dBContext = applicationContext;
            _logger = logger;
        }

        public virtual async Task<bool> Add(T entity)
        {
            var result = await _dbSet.AddAsync(entity);
            return true;
        }

        public virtual Task<bool> Delete(Guid Id)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<T> GetById(Guid Id)
        {
            return await _dbSet.FindAsync(Id);
        }

        public virtual Task<bool> Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
