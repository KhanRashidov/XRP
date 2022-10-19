namespace XRP.API.Models.Response.Accounts.AccountLine;

public class Line
{
    public string account { get; set; }
    public string balance { get; set; }
    public string currency { get; set; }
    public string limit { get; set; }
    public string limit_peer { get; set; }
    public bool no_ripple { get; set; }
    public bool no_ripple_peer { get; set; }
    public int quality_in { get; set; }
    public int quality_out { get; set; }
}