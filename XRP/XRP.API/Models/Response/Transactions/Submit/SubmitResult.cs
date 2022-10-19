namespace XRP.API.Models.Response.Transactions.Submit;

public class SubmitResult
{
    public bool accepted { get; set; }
    public int account_sequence_available { get; set; }
    public int account_sequence_next { get; set; }
    public bool applied { get; set; }
    public bool broadcast { get; set; }
    public string engine_result { get; set; }
    public int engine_result_code { get; set; }
    public string engine_result_message { get; set; }
    public bool kept { get; set; }
    public string open_ledger_cost { get; set; }
    public bool queued { get; set; }
    public string status { get; set; }
    public string tx_blob { get; set; }
    public SubmitTxJson tx_json { get; set; }
    public int validated_ledger_index { get; set; }
}