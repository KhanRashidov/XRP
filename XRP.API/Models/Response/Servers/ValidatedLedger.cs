namespace XRP.API.Models.Response.Servers;

public class ValidatedLedger
{
    public int age { get; set; }
    public double base_fee_xrp { get; set; }
    public string hash { get; set; }
    public int reserve_base_xrp { get; set; }
    public int reserve_inc_xrp { get; set; }
    public int seq { get; set; }
}