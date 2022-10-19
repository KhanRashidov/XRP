namespace XRP.API.Models.Response.Transactions;

public class NewFields
{
    public string Account { get; set; }
    public string BookDirectory { get; set; }
    public int Sequence { get; set; }
    public string TakerGets { get; set; }
    public TakerPays TakerPays { get; set; }
}