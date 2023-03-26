using Api.Rest.Enums;

namespace Api.Rest.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Password { get; set; }
        public UserStatus Status { get; set; }
    }
}
