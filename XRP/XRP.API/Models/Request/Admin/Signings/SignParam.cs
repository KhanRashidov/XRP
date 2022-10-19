namespace XRP.API.Models.Request.Admin.Signings;

public class SignParam
{
    public bool offline { get; set; }
    public string secret { get; set; }
    public SignTxJson tx_json { get; set; }
    public int fee_mult_max { get; set; }
}

public class Amount
{
    public string currency { get; set; }
    public string issuer { get; set; }
    public string value { get; set; }
}