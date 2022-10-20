namespace XRP.API.Models.Response.Admin.Signings.Sign;

public class SignResult
{
    public string status { get; set; }
    public string tx_blob { get; set; }
    public SignTxJson tx_json { get; set; }
}