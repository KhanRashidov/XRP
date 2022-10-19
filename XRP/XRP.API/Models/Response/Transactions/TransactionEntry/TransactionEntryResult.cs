namespace XRP.API.Models.Response.Transactions.TransactionEntry;

public class TransactionEntryResult
{
    public string ledger_hash { get; set; }
    public int ledger_index { get; set; }
    public Meta metadata { get; set; }
    public string status { get; set; }
    public TransactionEntryTxJson tx_json { get; set; }
    public bool validated { get; set; }
    public List<Warning> warnings { get; set; }
}