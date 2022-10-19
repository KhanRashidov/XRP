namespace XRP.API.Models.Response.Accounts.AccountChannels;

public class AccountChannelResult
{
    public string account { get; set; }
    public List<Channel> channels { get; set; }
    public string ledger_hash { get; set; }
    public int ledger_index { get; set; }
    public string status { get; set; }
    public bool validated { get; set; }
    public List<Warning> warnings { get; set; }
}