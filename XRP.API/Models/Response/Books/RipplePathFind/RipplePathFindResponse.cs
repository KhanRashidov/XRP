namespace XRP.API.Models.Response.Books.RipplePathFind
{
    public class RipplePathFindResponse
    {
        public int id { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public RipplePathFindResult result { get; set; }
    }
}
