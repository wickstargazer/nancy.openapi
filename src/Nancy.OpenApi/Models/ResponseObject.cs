namespace Nancy.OpenApi.Models
{
    public class ResponseObject
    {
        public string Description { get; set; }
        public SchemaObject Schema { get; set; }
        public HeadersObject Headers { get; set; }
        public ExampleObject Examples { get; set; }
    }
}