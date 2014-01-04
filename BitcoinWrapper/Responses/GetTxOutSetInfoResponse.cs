﻿using System;

namespace BitcoinWrapper.Responses
{
    public class GetTxOutSetInfoResponse
    {
        public Int32 Height { get; set; }
        public String BestBlock { get; set; }
        public Int32 Transactions { get; set; }
        public Int32 TxOuts { get; set; }
        public Int32 BytesSerialized { get; set; }
        public String HashSerialized { get; set; }
        public Double TotalAmount { get; set; }
    }
}
