namespace XRP.API.Models.Response.Transactions.TxHistory;

public class TxHistoryResult
{
    public int index { get; set; }
    public string status { get; set; }
    public List<HistoryTx> txs { get; set; }
    public bool used_postgres { get; set; }
    public List<Warning> warnings { get; set; }
}