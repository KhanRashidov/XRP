namespace XRP.API.Models.Response.Transactions.SubmitMultiSigned;

public class SubmitMultiRequest
{
    public string command { get; set; }
    public SubmitMultiTxJson tx_json { get; set; }
}