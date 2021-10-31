using LearnRepositoryPattern.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnRepositoryPattern.RepositoryInterface
{
    public interface IUserRepository : IGenericRepository<User>
    {
        
    }
}
