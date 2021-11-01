using Microsoft.EntityFrameworkCore;
using PlayerWallet.BL.Interfaces;
using PlayerWallet.BL.Model;
using PlayerWallet.DAL.DatabasesContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerWallet.BL.Repository
{
    public class PlayerRepository : GenericRepository<Player>, IPlayerRepository
    {
        private readonly PlayerDbContext _playerDbContext;


        public PlayerRepository(PlayerDbContext playerDbContext) : base(playerDbContext)
        {
            _playerDbContext = playerDbContext;
        }

        public async Task<IQueryable <Player>> GetPlayerById(Guid playerId)
        {
            return (IQueryable<Player>)await _dbset.Where(x => x.RegistrationId == playerId).FirstOrDefaultAsync();
        }
    }
}
