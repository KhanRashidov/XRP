namespace XRP.API.Models.Response.Accounts.AccountObject;

public class AccountObjectResult
{
    public string account { get; set; }
    public List<ObjectAccount> account_objects { get; set; }
    public string ledger_hash { get; set; }
    public int ledger_index { get; set; }
    public int limit { get; set; }
    public string marker { get; set; }
    public string status { get; set; }
    public bool validated { get; set; }
    public List<Warning> warnings { get; set; }
}