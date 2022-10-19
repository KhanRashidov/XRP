namespace XRP.API.Models.Response.Transactions;

public class FinalFields
{
    public string ExchangeRate { get; set; }
    public int Flags { get; set; }
    public string RootIndex { get; set; }
    public string TakerGetsCurrency { get; set; }
    public string TakerGetsIssuer { get; set; }
    public string TakerPaysCurrency { get; set; }
    public string TakerPaysIssuer { get; set; }
    public string Account { get; set; }
    public string Balance { get; set; }
    public int? OwnerCount { get; set; }
    public int? Sequence { get; set; }
    public string IndexNext { get; set; }
    public string IndexPrevious { get; set; }
    public string Owner { get; set; }
    public string BookDirectory { get; set; }
    public string BookNode { get; set; }
    public string OwnerNode { get; set; }
    public string PreviousTxnID { get; set; }
    public int PreviousTxnLgrSeq { get; set; }
    public string TakerGets { get; set; }
    public TakerPays TakerPays { get; set; }
}