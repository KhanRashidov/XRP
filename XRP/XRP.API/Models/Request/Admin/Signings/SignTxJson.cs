namespace XRP.API.Models.Request.Admin.Signings;

public class SignTxJson
{
    public string Account { get; set; }
    public Amount Amount { get; set; }
    public string Destination { get; set; }
    public string TransactionType { get; set; }

}