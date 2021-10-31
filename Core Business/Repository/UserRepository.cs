using LearnRepositoryPattern.DBContext;
using LearnRepositoryPattern.Entity;
using LearnRepositoryPattern.RepositoryInterface;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnRepositoryPattern.Core_Business.Repository
{
    public class UserRepository:GenericRepository<User>,IUserRepository
    {
        public UserRepository(ApplicationContext dBContext, ILogger logger) : base(dBContext, logger)
        {

        }

        public override Task<IEnumerable<User>> GetAll()
        {
            try
            {
                return _dbSet..ToList();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "{Repo} All method error", typeof(UserRepository));
                return new List<User>();
            }
        }
    }
}
