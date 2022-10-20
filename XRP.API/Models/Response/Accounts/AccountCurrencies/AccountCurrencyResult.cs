namespace XRP.API.Models.Response.Accounts.AccountCurrencies;

public class AccountCurrencyResult
{
    public string ledger_hash { get; set; }
    public int ledger_index { get; set; }
    //public IEnumerable<string> receive_currencies { get; set; }
    //public IEnumerable<string> send_currencies { get; set; }
    public string status { get; set; }
    public bool validated { get; set; }
    public List<Warning> warnings { get; set; }
}