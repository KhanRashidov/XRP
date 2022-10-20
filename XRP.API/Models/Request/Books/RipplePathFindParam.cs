namespace XRP.API.Models.Request.Books;

public class RipplePathFindParam
{
    public string destination_account { get; set; }
    public string source_account { get; set; }
    public  DestinationAmount destination_amount { get; set; }
    private List<SourceCurrency> source_currencies { get; set; }

}