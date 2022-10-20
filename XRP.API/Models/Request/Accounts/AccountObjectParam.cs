namespace XRP.API.Models.Request.Accounts
{
    public class AccountObjectParam:BaseAccountParam
    {
        public string ledger_index { get; set; }
        public string type { get; set; }
        public  bool deletion_blockers_only { get; set; }
        public  int limit { get; set; }
    }
}
