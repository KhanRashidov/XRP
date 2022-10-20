namespace XRP.API.Models.Request.PaymentChannel;

public class ChannelVerifyParam
{
    public string channel_id { get; set; }
    public string signature { get; set; }
    public string public_key { get; set; }
    public string amount { get; set; }
}