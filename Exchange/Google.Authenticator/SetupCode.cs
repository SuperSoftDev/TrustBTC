﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exchange.Google.Authenticator
{
    public class SetupCode
    {
        public string Account { get; internal set; }
        public string AccountSecretKey { get; internal set; }
        public string ManualEntryKey { get; internal set; }
        public string QrCodeSetupImageUrl { get; internal set; }
    }
}