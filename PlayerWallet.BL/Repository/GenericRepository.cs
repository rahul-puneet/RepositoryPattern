using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PlayerWallet.BL.Interfaces;
using PlayerWallet.DAL.DatabasesContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace PlayerWallet.BL.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _dbContext;
        protected DbSet<TEntity> _dbset;

        public GenericRepository(PlayerDbContext context)
        {
            _dbContext = context;
            _dbset = context?.Set<TEntity>();
        }

        public virtual void Add(TEntity entity)
        {
            _dbset.Add(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            if (_dbContext.Entry(entity).State == EntityState.Detached)
            {
                _dbContext.Attach(entity);
            }
            _dbContext.Remove(entity);
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            IQueryable<TEntity> query = _dbset;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (string property in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(property);
                }
            }
            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                query.ToList();
            }

            return null;
        }


        public virtual void Delete(object id)
        {
            TEntity entityDelete = _dbset.Find(id);
            _dbContext.Remove(entityDelete);
        }


        public TEntity GetByID(object Id)
        {
            return _dbset.Find(Id);
        }

        public virtual void Update(TEntity entity)
        {
            _dbset.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
