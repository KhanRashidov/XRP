namespace XRP.API.Models.Response.Servers.ServerInfo;

public class ServerInfoResult
{
    public Info info { get; set; }
    public string status { get; set; }
    public List<Warning> warnings { get; set; }
}