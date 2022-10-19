namespace XRP.API.Models.Request.Accounts
{
    public class AccountCurrencyParam:BaseAccountParam
    {
        public string ledger_index{ get; set; }
        public int account_index { get; set; }
        public bool strict { get; set; }
    }
}
