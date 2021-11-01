using PlayerWallet.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerWallet.BL.Interfaces
{
    public interface IPlayerRepository : IGenericRepository<Player>
    {
        Task<IQueryable<Player>> GetPlayerById(Guid playerId);
    }
}
