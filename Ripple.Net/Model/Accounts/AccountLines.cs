﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace RippleDotNet.Model.Accounts
{
    public class AccountLines
    {
        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("lines")]
        public List<TrustLine> TrustLines { get; set; }

        [JsonProperty("ledger_current_index")]
        public uint? LedgerCurrentIndex { get; set; }

        [JsonProperty("ledger_index")]
        public uint? LedgerIndex { get; set; }

        [JsonProperty("ledger_hash")]
        public string LedgerHash { get; set; }

        [JsonProperty("marker")]
        public object Marker { get; set; }
    }

    public class TrustLine
    {
        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("balance")]
        public string Balance { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("limit")]
        public string Limit { get; set; }

        [JsonProperty("limit_peer")]
        public string LimitPeer { get; set; }

        [JsonProperty("quality_in")]
        public uint QualityIn { get; set; }

        [JsonProperty("quality_out")]
        public uint QualityOut { get; set; }

        [JsonProperty("no_ripple")]
        public bool? NoRipple { get; set; }

        [JsonProperty("no_ripple_peer")]
        public bool? NoRipplePeer { get; set; }

        [JsonProperty("freeze")]
        public bool? Freeze { get; set; }

        [JsonProperty("freeze_peer")]
        public bool? FreezePeer { get; set; }
    }
}
