namespace Api.Rest.Models
{
    public class Account
    {
        public string Id { get; set; }
        public string Address { get; set; }
        public bool IsClosed { get; set; }
        public DateTime Open { get; set; }
        public DateTime Closed { get; set; }
    }
}
