namespace XRP.API.Models.Response.Ledgers.LedgerClosed
{
    public class LedgerClosedResponse
    {
        public bool forwarded { get; set; }
        public LedgerClosed result { get; set; }
        public string type { get; set; }
        public List<Warning> warnings { get; set; }
    }
}
