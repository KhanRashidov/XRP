namespace XRP.API.Models.Response.Accounts.AccountTx;

public class FinalFields
{
    public string Account { get; set; }
    public string Balance { get; set; }
    public int Flags { get; set; }
    public int OwnerCount { get; set; }
    public int Sequence { get; set; }
    public string Owner { get; set; }
    public string RootIndex { get; set; }
    public string MessageKey { get; set; }
    public HighLimit HighLimit { get; set; }
    public string HighNode { get; set; }
    public LowLimit LowLimit { get; set; }
    public string LowNode { get; set; }
    public string PreviousTxnID { get; set; }
    public int? PreviousTxnLgrSeq { get; set; }
}