namespace CodedByKay.BondBridge.Models.Models
{
    public class Group
    {
        public Guid GroupId { get; set; }
        public string GroupName { get; set; } 
        public ICollection<User> Members { get; set; }
        public ICollection<Message> Messages { get; set; }
    }
}
