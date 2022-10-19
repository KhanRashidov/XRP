namespace XRP.API.Models.Response;

public class Balance
{
    public string currency { get; set; }
    public string issuer { get; set; }
    public string value { get; set; }
}