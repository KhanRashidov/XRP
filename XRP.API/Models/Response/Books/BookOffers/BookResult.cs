namespace XRP.API.Models.Response.Books.BookOffers;

public class BookResult
{
    public string ledger_hash { get; set; }
    public int ledger_index { get; set; }
    public List<Offer> offers { get; set; }
    public string status { get; set; }
    public bool validated { get; set; }
    public List<Warning> warnings { get; set; }
}