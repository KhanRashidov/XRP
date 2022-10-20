namespace XRP.API.Models.Request.Accounts;

public class GatewayBalanceParam:BaseAccountParam
{

    //public string[] hotwallet { get; set; }
    public string ledger_index { get; set; }
    public bool strict { get; set; }
}