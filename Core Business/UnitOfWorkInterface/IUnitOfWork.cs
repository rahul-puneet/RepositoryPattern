using LearnRepositoryPattern.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnRepositoryPattern.UnitOfWorkInterface
{
    public interface IUnitOfWork
    {
        IUserRepository User { get; }

        Task CompleteAsync();
    }
}
