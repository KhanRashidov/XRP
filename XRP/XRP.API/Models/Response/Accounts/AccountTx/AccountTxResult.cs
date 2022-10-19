namespace XRP.API.Models.Response.Accounts.AccountTx;

public class AccountTxResult
{
    public string account { get; set; }
    public int ledger_index_max { get; set; }
    public int ledger_index_min { get; set; }
    public int limit { get; set; }
    public Marker marker { get; set; }
    public string status { get; set; }
    public List<Transaction> transactions { get; set; }
    public bool used_postgres { get; set; }
    public bool validated { get; set; }
    public List<Warning> warnings { get; set; }
}