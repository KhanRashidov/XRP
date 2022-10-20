namespace XRP.API.Models.Response.Transactions.Tx
{
    public class TxResponse
    {
        public TxResult result { get; set; }
    }

    public class TxResult
    {
        public string Account { get; set; }
        public string Fee { get; set; }
        public int Flags { get; set; }
        public int LastLedgerSequence { get; set; }
        public int OfferSequence { get; set; }
        public int Sequence { get; set; }
        public string SigningPubKey { get; set; }
        public string TakerGets { get; set; }
        public TakerPays TakerPays { get; set; }
        public string TransactionType { get; set; }
        public string TxnSignature { get; set; }
        public int date { get; set; }
        public string hash { get; set; }
        public int inLedger { get; set; }
        public int ledger_index { get; set; }
        public Meta meta { get; set; }
        public string status { get; set; }
        public bool validated { get; set; }
        public List<Warning> warnings { get; set; }
    }

   
   
}
