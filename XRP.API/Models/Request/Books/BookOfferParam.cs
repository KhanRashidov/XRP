namespace XRP.API.Models.Request.Books;

public class BookOfferParam
{
    public string taker { get; set; }
    public TakerGet taker_gets { get; set; }
    public TakerPay taker_pays { get; set; }
    public int limit { get; set; }
}