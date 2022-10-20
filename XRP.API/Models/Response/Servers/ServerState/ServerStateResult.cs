namespace XRP.API.Models.Response.Servers.ServerState;

public class ServerStateResult
{
    public State state { get; set; }
    public string status { get; set; }
    public List<Warning> warnings { get; set; }
}