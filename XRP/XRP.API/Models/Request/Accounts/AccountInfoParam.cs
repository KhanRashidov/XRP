namespace XRP.API.Models.Request.Accounts
{
    public class AccountInfoParam:BaseAccountParam
    {
        public bool strict { get; set; }
        public string ledger_index { get; set; }
        public int api_version { get; set; }
    }
}
