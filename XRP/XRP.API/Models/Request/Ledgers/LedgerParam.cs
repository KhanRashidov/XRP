namespace XRP.API.Models.Request.Ledgers;

public class LedgerParam
{
    public string ledger_index { get; set; }
    public string accounts { get; set; }
    public bool full { get; set; }
    public bool transactions  { get; set; }
    public bool expand { get; set; }
    public bool owner_funds { get; set; }

}