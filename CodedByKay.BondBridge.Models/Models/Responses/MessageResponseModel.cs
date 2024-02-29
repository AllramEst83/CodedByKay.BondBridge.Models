using CodedByKay.BondBridge.Models.Models.Responses;

namespace CodedByKay.BondBridge.Models.Models.Requests
{
    public class MessageResponseModel
    {
        public Guid MessageId { get; set; }

        public Guid GroupId { get; set; }

        public Guid SenderId { get; set; }

        public string Content { get; set; }

        public DateTime Timestamp { get; set; }

        public ICollection<ReadReceiptResponseModel> ReadReceiptResponseModel { get; set; }
    }
}
