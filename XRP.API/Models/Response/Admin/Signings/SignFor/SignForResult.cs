namespace XRP.API.Models.Response.Admin.Signings.SignFor;

public class SignForResult
{
    public string status { get; set; }
    public string tx_blob { get; set; }
    public SignForTxJson tx_json { get; set; }
}