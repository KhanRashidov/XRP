namespace XRP.API.Models.Response.Books.RipplePathFind;

public class Alternative
{
    public List<string> paths_canonical { get; set; }
    public List<Computed> paths_computed { get; set; }
    public string source_amount { get; set; }
}