namespace XRP.API.Models.Response.Accounts.AccountObject;

public class ObjectAccount
{
    public Balance Balance { get; set; }
    public int Flags { get; set; }
    public HighLimit HighLimit { get; set; }
    public string HighNode { get; set; }
    public string LedgerEntryType { get; set; }
    public LowLimit LowLimit { get; set; }
    public string LowNode { get; set; }
    public string PreviousTxnID { get; set; }
    public int PreviousTxnLgrSeq { get; set; }
    public string index { get; set; }
}