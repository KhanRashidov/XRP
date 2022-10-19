namespace XRP.API.Models.Response.Accounts.AccountTx;

public class DeletedNode
{
    public FinalFields FinalFields { get; set; }
    public string LedgerEntryType { get; set; }
    public string LedgerIndex { get; set; }
    public PreviousFields PreviousFields { get; set; }
}