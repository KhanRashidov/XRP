namespace XRP.API.Models.Request.Admin.Signings;

public class SignForParam
{
    public string account { get; set; }
    public string seed { get; set; }
    public string key_type { get; set; }
    public SignForTxJson tx_json { get; set; }

}