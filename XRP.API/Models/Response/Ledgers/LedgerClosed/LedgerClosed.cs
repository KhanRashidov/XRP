namespace XRP.API.Models.Response.Ledgers.LedgerClosed;

public class LedgerClosed
{
    public string ledger_hash { get; set; }
    public int ledger_index { get; set; }
    public string status { get; set; }
}