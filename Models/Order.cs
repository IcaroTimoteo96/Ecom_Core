using Api.Rest.Enums;

namespace Api.Rest.Models
{
    public class Order
    {
        public string Id { get; set; }
        public DateTime Ordered { get; set; }
        public DateTime Shipped { get; set; }
        public string ShipTo { get; set;}
        public OrderStatus Status { get; set; }
        public double Total { get; set; }
    }
}
