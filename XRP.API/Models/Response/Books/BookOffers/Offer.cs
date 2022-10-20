namespace XRP.API.Models.Response.Books.BookOffers;

public class Offer
{
    public string Account { get; set; }
    public string BookDirectory { get; set; }
    public string BookNode { get; set; }
    public int Flags { get; set; }
    public string LedgerEntryType { get; set; }
    public string OwnerNode { get; set; }
    public string PreviousTxnID { get; set; }
    public int PreviousTxnLgrSeq { get; set; }
    public int Sequence { get; set; }
    public string TakerGets { get; set; }
    public TakerPays TakerPays { get; set; }
    public string index { get; set; }
    public string owner_funds { get; set; }
    public string quality { get; set; }
    public int? Expiration { get; set; }
}