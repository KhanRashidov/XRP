namespace XRP.API.Models.Response.Accounts.NorippleCheck;

public class NorippleCheckTransaction
{
    public string Account { get; set; }
    public int Fee { get; set; }
    public int Sequence { get; set; }
    public int SetFlag { get; set; }
    public string TransactionType { get; set; }
    public int? Flags { get; set; }
    public LimitAmount LimitAmount { get; set; }
}