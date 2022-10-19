namespace XRP.API.Models.Response.Ledgers.LedgerEntry;

public class LedgerEntryNode
{
    public List<string> Amendments { get; set; }
    public int Flags { get; set; }
    public string LedgerEntryType { get; set; }
    public List<Majority> Majorities { get; set; }
    public string index { get; set; }
}