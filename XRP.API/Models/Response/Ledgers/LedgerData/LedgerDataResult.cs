namespace XRP.API.Models.Response.Ledgers.LedgerData;

public class LedgerDataResult
{
    public DataLedger ledger { get; set; }
    public string ledger_hash { get; set; }
    public int ledger_index { get; set; }
    public string marker { get; set; }
    public List<State> state { get; set; }
    public string status { get; set; }
    public bool validated { get; set; }
    public List<Warning> warnings { get; set; }
}