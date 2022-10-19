namespace XRP.API.Models.Request
{
    public class BaseEntity<T> : IBaseEntity<T>
    {
        public string method { get; set; }
        public List<T> @params { get; set; }
    }
}
