namespace XRP.API.Models.Response.Accounts.AccountOffers;

public class AccountOfferResult
{
    public string account { get; set; }
    public string ledger_hash { get; set; }
    public int ledger_index { get; set; }
    public List<object> offers { get; set; }
    public string status { get; set; }
    public bool validated { get; set; }
    public List<Warning> warnings { get; set; }
}