namespace XRP.API.Models.Response.Books.RipplePathFind;

public class RipplePathFindResult
{
    public List<Alternative> alternatives { get; set; }
    public string destination_account { get; set; }
    public List<string> destination_currencies { get; set; }
    public string status { get; set; }
}