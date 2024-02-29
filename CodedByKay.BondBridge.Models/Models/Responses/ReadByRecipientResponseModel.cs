namespace CodedByKay.BondBridge.Models.Models.Responses
{
    public class ReadReceiptResponseModel
    {
        public Guid MessageId { get; set; }
        public ICollection<UserReadReceiptModel> ReadByUsers { get; set; }
    }
}
