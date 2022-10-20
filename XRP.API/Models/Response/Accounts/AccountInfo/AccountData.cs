namespace XRP.API.Models.Response.Accounts.AccountInfo;

public class AccountData
{
    public string Account { get; set; }
    public string Balance { get; set; }
    public int Flags { get; set; }
    public string LedgerEntryType { get; set; }
    public string MessageKey { get; set; }
    public int OwnerCount { get; set; }
    public string PreviousTxnID { get; set; }
    public int PreviousTxnLgrSeq { get; set; }
    public string RegularKey { get; set; }
    public int Sequence { get; set; }
    public string index { get; set; }
}