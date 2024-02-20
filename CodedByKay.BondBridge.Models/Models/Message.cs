namespace CodedByKay.BondBridge.Models.Models
{
    public class Message
    {
        public Guid MessageId { get; set; }
        public Guid GroupId { get; set; }
        public Guid SenderId { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
        public ICollection<Guid> ReadBy { get; set; }
    }
}
