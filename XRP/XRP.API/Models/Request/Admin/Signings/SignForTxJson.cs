using XRP.API.Models.Request.Transactions;

namespace XRP.API.Models.Request.Admin.Signings;

public class SignForTxJson
{
    public string TransactionType { get; set; }
    public string Account { get; set; }
    public int Flags { get; set; }
    public LimitAmount LimitAmount { get; set; }
    public int Sequence { get; set; }
    public string SigningPubKey { get; set; }
    public string Fee { get; set; }


}