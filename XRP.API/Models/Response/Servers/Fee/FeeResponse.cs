namespace XRP.API.Models.Response.Servers.Fee
{
    public class FeeResponse
    {
        public bool forwarded { get; set; }
        public FeeResult result { get; set; }
        public string type { get; set; }
        public List<Warning> warnings { get; set; }
    }
}
