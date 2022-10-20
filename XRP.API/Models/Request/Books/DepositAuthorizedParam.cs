namespace XRP.API.Models.Request.Books;

public class DepositAuthorizedParam
{
    public string source_account { get; set; }
    public string destination_account { get; set; }
    public string ledger_index { get; set; }
}