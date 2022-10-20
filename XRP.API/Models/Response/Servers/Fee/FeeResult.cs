namespace XRP.API.Models.Response.Servers.Fee;

public class FeeResult
{
    public string current_ledger_size { get; set; }
    public string current_queue_size { get; set; }
    public Drops drops { get; set; }
    public string expected_ledger_size { get; set; }
    public int ledger_current_index { get; set; }
    public Levels levels { get; set; }
    public string max_queue_size { get; set; }
    public string status { get; set; }
}