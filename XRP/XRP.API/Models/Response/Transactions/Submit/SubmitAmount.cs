namespace XRP.API.Models.Response.Transactions.Submit;

public class SubmitAmount
{
    public string currency { get; set; }
    public string issuer { get; set; }
    public string value { get; set; }
}