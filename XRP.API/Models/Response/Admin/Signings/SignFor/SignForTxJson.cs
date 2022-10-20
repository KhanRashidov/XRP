namespace XRP.API.Models.Response.Admin.Signings.SignFor;

public class SignForTxJson
{
    public string Account { get; set; }
    public string Fee { get; set; }
    public int Flags { get; set; }
    public LimitAmount LimitAmount { get; set; }
    public int Sequence { get; set; }
    public List<SignForSigner> Signers { get; set; }
    public string SigningPubKey { get; set; }
    public string TransactionType { get; set; }
    public string hash { get; set; }
}