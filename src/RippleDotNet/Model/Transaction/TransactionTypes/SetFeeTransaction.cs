﻿using Ripple.WebSocketClient.Model.Transaction.Interfaces;

namespace Ripple.WebSocketClient.Model.Transaction.TransactionTypes
{
    public class SetFeeTransaction : TransactionCommon, ISetFeeTransaction
    {
        public SetFeeTransaction()
        {
            TransactionType = TransactionType.SetFee;
        }

        public string BaseFee { get; set; }

        public uint ReferenceFeeUnits { get; set; }

        public uint ReserveBase { get; set; }

        public uint ReserveIncrement { get; set; }

        public uint LedgerSequence { get; set; }
    }
}
