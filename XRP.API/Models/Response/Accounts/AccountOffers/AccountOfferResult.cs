namespace XRP.API.Models.Response.Accounts.AccountOffers;

public class AccountOfferResult
{
    public string account { get; set; }
    public int ledger_current_index { get; set; }
    public List<Offer> offers { get; set; }
    public string status { get; set; }
    public bool validated { get; set; }
}

