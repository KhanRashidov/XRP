namespace XRP.API.Models.Request.Accounts;

public class AccountTxParam:BaseAccountParam
{
    public bool binary { get; set; }
    public  bool forward { get; set; }
    public  int ledger_index_max { get; set; }
    public int ledger_index_min { get; set; }
    public  int limit { get; set; }

}