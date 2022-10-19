namespace XRP.API.Models.Response.Accounts.AccountInfo
{
    public class AccountInfoResponse
    {
        public bool forwarded { get; set; }
        public AccountInfoResult result { get; set; }
        public string type { get; set; }
        public List<Warning> warnings { get; set; }
    }
}
