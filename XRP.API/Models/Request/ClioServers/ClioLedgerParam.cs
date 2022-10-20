namespace XRP.API.Models.Request.ClioServers;

public class ClioLedgerParam
{
    public string ledger_index { get; set; }
    public bool accounts { get; set; }
    public bool full { get; set; }
    public bool transactions { get; set; }
    public bool expand { get; set; }
    public bool owner_funds { get; set; }
    public bool diff { get; set; }

}