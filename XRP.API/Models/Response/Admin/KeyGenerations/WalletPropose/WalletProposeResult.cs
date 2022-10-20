namespace XRP.API.Models.Response.Admin.KeyGenerations.WalletPropose;

public class WalletProposeResult
{
    public string account_id { get; set; }
    public string key_type { get; set; }
    public string master_key { get; set; }
    public string master_seed { get; set; }
    public string master_seed_hex { get; set; }
    public string public_key { get; set; }
    public string public_key_hex { get; set; }
    public string status { get; set; }
}