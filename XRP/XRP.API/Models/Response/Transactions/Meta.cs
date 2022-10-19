namespace XRP.API.Models.Response.Transactions;

public class Meta
{
    public List<AffectedNode> AffectedNodes { get; set; }
    public int TransactionIndex { get; set; }
    public string TransactionResult { get; set; }
}