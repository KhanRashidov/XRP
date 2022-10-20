namespace XRP.API.Models.Response.Servers;

public class Reporting
{
    public List<EtlSource> etl_sources { get; set; }
    public bool is_writer { get; set; }
    public string last_publish_time { get; set; }
}