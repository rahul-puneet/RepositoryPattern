using PlayerWallet.BL.Interfaces;
using PlayerWallet.BL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerWallet.BL.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IUnityOfWork _unityOfWork;
        public PlayerService(IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }

        public void AddBalance(decimal balanceAmount, Guid walletId)
        {
            throw new NotImplementedException();
        }

        public void CreatePlayer(Player player)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Player> GetAll()
        {
            throw new NotImplementedException();
        }

        public Player GetPlayerById()
        {
            throw new NotImplementedException();
        }

        public void UpdatePlayerDetails(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
