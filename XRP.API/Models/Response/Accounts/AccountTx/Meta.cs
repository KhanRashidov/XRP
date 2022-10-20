namespace XRP.API.Models.Response.Accounts.AccountTx;

public class Meta
{
    public List<AffectedNode> AffectedNodes { get; set; }
    public int TransactionIndex { get; set; }
    public string TransactionResult { get; set; }
    public string delivered_amount { get; set; }
}