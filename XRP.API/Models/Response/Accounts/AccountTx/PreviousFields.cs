namespace XRP.API.Models.Response.Accounts.AccountTx;

public class PreviousFields
{
    public string Balance { get; set; }
    public int? Sequence { get; set; }
    public int? OwnerCount { get; set; }
    public int Flags { get; set; }
    public LowLimit LowLimit { get; set; }
}