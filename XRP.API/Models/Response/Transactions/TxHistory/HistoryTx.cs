using XRP.API.Models.Request.Admin.Signings;
using XRP.API.Models.Request.Books;

namespace XRP.API.Models.Response.Transactions.TxHistory;

public class HistoryTx
{
    public string Account { get; set; }
    //public Amount Amount { get; set; }
    public string Destination { get; set; }
    public string Fee { get; set; }
    public int Flags { get; set; }
    public int LastLedgerSequence { get; set; }
    public List<Memo> Memos { get; set; }
    public int Sequence { get; set; }
    public string SigningPubKey { get; set; }
    public string TransactionType { get; set; }
    public string TxnSignature { get; set; }
    public string hash { get; set; }
    public int inLedger { get; set; }
    public int ledger_index { get; set; }
    //public TakerGet TakerGets { get; set; }
    public TakerPays TakerPays { get; set; }
    public SendMax SendMax { get; set; }
    public int? OfferSequence { get; set; }
    public int? DestinationTag { get; set; }
}