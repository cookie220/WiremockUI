﻿using System;
using System.Collections.Generic;

namespace WiremockUI.Data
{
    public class Settings
    {
        public Guid Id { get; set; }
        public Dictionary<string, string> Languages { get; set; } = new Dictionary<string, string>();
        public string DefaultLanguage { get; set; }
        public string TrustStoreDefault { get; set; }
        public string TrustStorePwdDefault { get; set; }
    }
}
