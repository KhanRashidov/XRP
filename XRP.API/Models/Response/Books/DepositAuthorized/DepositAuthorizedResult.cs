namespace XRP.API.Models.Response.Books.DepositAuthorized;

public class DepositAuthorizedResult
{
    public bool deposit_authorized { get; set; }
    public string destination_account { get; set; }
    public string ledger_hash { get; set; }
    public int ledger_index { get; set; }
    public string source_account { get; set; }
    public string status { get; set; }
    public bool validated { get; set; }
}