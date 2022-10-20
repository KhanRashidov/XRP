namespace XRP.API.Models.Request.PaymentChannel;

public class ChannelAuthorizeParam
{
    public string channel_id { get; set; }
    public string seed { get; set; }
    public string key_type { get; set; }
    public string  amount { get; set; }
}