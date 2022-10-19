namespace XRP.API.Models.Response.Ledgers.LedgerCurrent
{
    public class LedgerCurrentResponse
    {
        public bool forwarded { get; set; }
        public LedgerCurrentResult result { get; set; }
        public string type { get; set; }
        public List<Warning> warnings { get; set; }
    }
}
