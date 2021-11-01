using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PlayerWallet.DAL.Entities
{
    [Table("Players"), Serializable]
    public class PlayerDTO
    {
        [Key]
        public Guid RegistrationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailID { get; set; }
        public virtual List<PlayerWalletDTO> playerWalletDetails { get; set; } // this is needed to track all the transactions
    }
}
