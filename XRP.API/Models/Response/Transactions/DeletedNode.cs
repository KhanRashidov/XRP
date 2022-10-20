namespace XRP.API.Models.Response.Transactions;

public class DeletedNode
{
    public FinalFields FinalFields { get; set; }
    public string LedgerEntryType { get; set; }
    public string LedgerIndex { get; set; }
}