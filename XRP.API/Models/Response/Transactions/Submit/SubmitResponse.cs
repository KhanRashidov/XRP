namespace XRP.API.Models.Response.Transactions.Submit
{
    public class SubmitResponse
    {
        public bool forwarded { get; set; }
        public SubmitResult result { get; set; }
        public string type { get; set; }
        public List<Warning> warnings { get; set; }
    }
}
