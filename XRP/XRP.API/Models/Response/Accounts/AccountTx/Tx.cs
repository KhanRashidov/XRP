namespace XRP.API.Models.Response.Accounts.AccountTx;

public class Tx
{
    public string Account { get; set; }
    public string Amount { get; set; }
    public string Destination { get; set; }
    public long DestinationTag { get; set; }
    public string Fee { get; set; }
    public int LastLedgerSequence { get; set; }
    public int Sequence { get; set; }
    public string SigningPubKey { get; set; }
    public string TransactionType { get; set; }
    public string TxnSignature { get; set; }
    public int date { get; set; }
    public string hash { get; set; }
    public int inLedger { get; set; }
    public int ledger_index { get; set; }
    public long? Flags { get; set; }
    public LimitAmount LimitAmount { get; set; }
}