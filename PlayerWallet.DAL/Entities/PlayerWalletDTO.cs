using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PlayerWallet.DAL.Entities
{
    [Table("PlayerWallet"), Serializable]
    public class PlayerWalletDTO
    {
        [Key]
        public Guid ID { get; set; }

        [ForeignKey("RegistrationId")]
        public Guid PlayerId { get; set; }
        public virtual PlayerDTO Player { get; set; }
       
    }
}
