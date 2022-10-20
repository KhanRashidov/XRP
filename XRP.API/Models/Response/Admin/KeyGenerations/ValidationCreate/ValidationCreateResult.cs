namespace XRP.API.Models.Response.Admin.KeyGenerations.ValidationCreate;

public class ValidationCreateResult
{
    public string status { get; set; }
    public string validation_key { get; set; }
    public string validation_public_key { get; set; }
    public string validation_seed { get; set; }
}