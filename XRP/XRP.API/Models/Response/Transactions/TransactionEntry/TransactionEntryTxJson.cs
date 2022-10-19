namespace XRP.API.Models.Response.Transactions.TransactionEntry;

public class TransactionEntryTxJson
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
    public string hash { get; set; }
}