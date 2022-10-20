namespace XRP.API.Models.Response.PaymentChannel.ChannelVerify;

public class ChannelVerifyResult
{
    public bool signature_verified { get; set; }
    public string status { get; set; }
    public List<Warning> warnings { get; set; }
}