namespace CodedByKay.BondBridge.Models.Models.Responses
{
    public class UserReadReceiptModel
    {
        public Guid UserId { get; set; }
        public DateTime ReadAt { get; set; }
        public string Username { get; set; }
        public string ImagePath { get; set; }
    }
}
