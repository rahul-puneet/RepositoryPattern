﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PlayerWallet.BL.CommonHelper
{
    public class BusinessException:Exception
    {
        public BusinessException() : base() { }

        public BusinessException(string message) : base(message) { }

        public BusinessException(string message, params object[] args)
            : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
    }
}
