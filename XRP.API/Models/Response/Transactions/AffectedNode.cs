namespace XRP.API.Models.Response.Transactions;

public class AffectedNode
{
    public ModifiedNode ModifiedNode { get; set; }
    public DeletedNode DeletedNode { get; set; }
    public CreatedNode CreatedNode { get; set; }
}