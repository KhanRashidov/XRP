namespace XRP.API.Models.Response.Transactions;

public class CreatedNode
{
    public string LedgerEntryType { get; set; }
    public string LedgerIndex { get; set; }
    public NewFields NewFields { get; set; }
}