namespace XRP.API.Models.Response.Admin.Loggings.CrawlShards;

public class CrawlResult
{
    public string complete_shards { get; set; }
    public List<CrawlPeer> peers { get; set; }
    public string status { get; set; }
}