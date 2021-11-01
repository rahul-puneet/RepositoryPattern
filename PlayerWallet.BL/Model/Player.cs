using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerWallet.BL.Model
{
    public class Player
    {
        public Guid RegistrationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailID { get; set; }
    }
}
