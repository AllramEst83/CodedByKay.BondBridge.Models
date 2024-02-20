namespace CodedByKay.BondBridge.Models.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public ICollection<Group> Groups { get; set; }
    }
}
