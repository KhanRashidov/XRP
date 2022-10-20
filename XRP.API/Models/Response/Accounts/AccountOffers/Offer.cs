namespace XRP.API.Models.Response.Accounts.AccountOffers;

public class Offer
{
    public int flags { get; set; }
    public string quality { get; set; }
    public int seq { get; set; }
    public string taker_gets { get; set; }
    public TakerPays taker_pays { get; set; }
}