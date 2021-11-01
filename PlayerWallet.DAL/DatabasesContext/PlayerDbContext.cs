using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PlayerWallet.DAL.Entities;

namespace PlayerWallet.DAL.DatabasesContext
{
    public class PlayerDbContext : DbContext
    {
        private readonly IConfiguration _iConfiguration;

        public PlayerDbContext(IConfiguration configuration)
        {
            _iConfiguration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseInMemoryDatabase("PlayersWalletDB");
        }

        public DbSet<PlayerWalletDTO> PlayerWalletBalance { get; set; }
        public DbSet<PlayerDTO> Player { get; set; }
    }
}
