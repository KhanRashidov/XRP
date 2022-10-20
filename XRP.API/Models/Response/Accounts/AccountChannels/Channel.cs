namespace XRP.API.Models.Response.Accounts.AccountChannels;

public class Channel
{
    public string account { get; set; }
    public string amount { get; set; }
    public string balance { get; set; }
    public string channel_id { get; set; }
    public string destination_account { get; set; }
    public string public_key { get; set; }
    public string public_key_hex { get; set; }
    public int settle_delay { get; set; }
}