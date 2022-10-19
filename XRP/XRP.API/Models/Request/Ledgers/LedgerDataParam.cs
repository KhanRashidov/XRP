namespace XRP.API.Models.Request.Ledgers;

public class LedgerDataParam
{
    public bool binary { get; set; }
    public string ledger_hash { get; set; }
    public int limit { get; set; }
}