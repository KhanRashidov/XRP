namespace XRP.API.Models.Response.Accounts.AccountTx;

public class Transaction
{
    public Meta meta { get; set; }
    public Tx tx { get; set; }
    public bool validated { get; set; }
}