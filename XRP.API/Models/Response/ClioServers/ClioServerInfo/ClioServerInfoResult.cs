using XRP.API.Models.Response.Servers.ServerInfo;

namespace XRP.API.Models.Response.ClioServers.ClioServerInfo;

public class ClioServerInfoResult
{
    public Info info { get; set; }
    public string status { get; set; }
    public List<Warning> warnings { get; set; }
}