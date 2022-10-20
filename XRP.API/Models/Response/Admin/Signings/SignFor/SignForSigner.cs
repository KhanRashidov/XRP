namespace XRP.API.Models.Response.Admin.Signings.SignFor;

public class SignForSigner
{
    public string Account { get; set; }
    public string SigningPubKey { get; set; }
    public string TxnSignature { get; set; }
}