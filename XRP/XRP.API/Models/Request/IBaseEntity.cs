namespace XRP.API.Models.Request;

public interface IBaseEntity<T>
{
    public string method { get; set; }
}