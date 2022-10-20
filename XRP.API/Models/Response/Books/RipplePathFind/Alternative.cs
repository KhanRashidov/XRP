namespace XRP.API.Models.Response.Books.RipplePathFind;

public class Alternative
{
    public List<object> paths_canonical { get; set; }
    public List<List<Computed>> paths_computed { get; set; }
    public string source_amount { get; set; }
}