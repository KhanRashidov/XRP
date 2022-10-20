namespace XRP.API.Models.Response.Ledgers.Ledger;

public class LedgerModel
{
    public bool accepted { get; set; }
    public string account_hash { get; set; }
    public int close_flags { get; set; }
    public int close_time { get; set; }
    public string close_time_human { get; set; }
    public int close_time_resolution { get; set; }
    public bool closed { get; set; }
    public string hash { get; set; }
    public string ledger_hash { get; set; }
    public string ledger_index { get; set; }
    public int parent_close_time { get; set; }
    public string parent_hash { get; set; }
    public string seqNum { get; set; }
    public string totalCoins { get; set; }
    public string total_coins { get; set; }
    public string transaction_hash { get; set; }
}