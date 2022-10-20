namespace XRP.API.Models.Response.Servers;

public class StateAccounting
{
    public Connected connected { get; set; }
    public Disconnected disconnected { get; set; }
    public Full full { get; set; }
    public Syncing syncing { get; set; }
    public Tracking tracking { get; set; }
}