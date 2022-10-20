namespace XRP.API.Models.Response.Servers;

public class EtlSource
{
    public bool connected { get; set; }
    public string grpc_port { get; set; }
    public string ip { get; set; }
    public string last_message_arrival_time { get; set; }
    public string validated_ledgers_range { get; set; }
    public string websocket_port { get; set; }
}