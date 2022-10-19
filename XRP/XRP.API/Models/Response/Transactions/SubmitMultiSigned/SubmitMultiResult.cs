namespace XRP.API.Models.Response.Transactions.SubmitMultiSigned;

public class SubmitMultiResult
{
    public string error { get; set; }
    public int error_code { get; set; }
    public string error_message { get; set; }
    public bool forwarded { get; set; }
    public SubmitMultiRequest request { get; set; }
    public string status { get; set; }
    public string type { get; set; }
    public List<Warning> warnings { get; set; }
}