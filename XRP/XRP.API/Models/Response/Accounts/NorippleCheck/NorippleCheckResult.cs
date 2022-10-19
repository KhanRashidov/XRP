namespace XRP.API.Models.Response.Accounts.NorippleCheck;

public class NorippleCheckResult
{
    public int ledger_current_index { get; set; }
    public List<string> problems { get; set; }
    public string status { get; set; }
    public List<NorippleCheckTransaction> transactions { get; set; }
    public bool validated { get; set; }
}