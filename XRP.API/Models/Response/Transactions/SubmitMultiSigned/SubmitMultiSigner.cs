namespace XRP.API.Models.Response.Transactions.SubmitMultiSigned;

public class SubmitMultiSigner
{
    public string Account { get; set; }
    public string SigningPubKey { get; set; }
    public string TxnSignature { get; set; }
}