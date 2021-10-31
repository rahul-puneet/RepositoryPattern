using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnRepositoryPattern.RepositoryInterface
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetById(Guid Id);

        Task<IEnumerable<T>> GetAll();

        Task<bool> Add(T entity);

        Task<bool> Delete(Guid Id);

        Task<bool> Update(T entity);
    }
}
