namespace XRP.API.Models.Response.Accounts.NorippleCheck
{
    public class NorippleCheckResponse
    {
        public bool forwarded { get; set; }
        public NorippleCheckResult result { get; set; }
        public string type { get; set; }
        public List<Warning> warnings { get; set; }
    }
}
