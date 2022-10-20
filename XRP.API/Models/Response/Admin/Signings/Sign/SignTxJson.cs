namespace XRP.API.Models.Response.Admin.Signings.Sign;

public class SignTxJson
{
    public string Account { get; set; }
    public SignAmount Amount { get; set; }
    public string Destination { get; set; }
    public string Fee { get; set; }
    public long Flags { get; set; }
    public int Sequence { get; set; }
    public string SigningPubKey { get; set; }
    public string TransactionType { get; set; }
    public string TxnSignature { get; set; }
    public string hash { get; set; }
}