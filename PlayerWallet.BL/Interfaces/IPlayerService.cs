using PlayerWallet.BL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerWallet.BL.Interfaces
{
    public interface IPlayerService
    {
        IEnumerable<Player> GetAll();

        Player GetPlayerById();

        void CreatePlayer(Player player);
        void UpdatePlayerDetails(Player player);

        void AddBalance(decimal balanceAmount, Guid walletId);
    }
}
