namespace XRP.API.Models.Response.Accounts.AccountTx;

public class ModifiedNode
{
    public FinalFields FinalFields { get; set; }
    public string LedgerEntryType { get; set; }
    public string LedgerIndex { get; set; }
    public PreviousFields PreviousFields { get; set; }
    public string PreviousTxnID { get; set; }
    public int PreviousTxnLgrSeq { get; set; }
}