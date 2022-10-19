
namespace XRP.API.Models.Request.Accounts
{
    public class AccountChannelParam:BaseAccountParam
    {
        public string destination_account { get; set; }
        public string ledger_index { get; set; }


    }
}
