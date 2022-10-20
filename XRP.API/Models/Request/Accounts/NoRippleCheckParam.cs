namespace XRP.API.Models.Request.Accounts;

public class NoRippleCheckParam : BaseAccountParam
{
    public string ledger_index { get; set; }
    public int limit { get; set; }
    public string role { get; set; }
    public bool transactions { get; set; }
        

}