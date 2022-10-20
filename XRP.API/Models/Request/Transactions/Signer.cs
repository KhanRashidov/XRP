namespace XRP.API.Models.Request.Transactions;

public class Signer
{
    public string Account { get; set; }
    public string SigningPubKey { get; set; }
    public string TxnSignature { get; set; }
}