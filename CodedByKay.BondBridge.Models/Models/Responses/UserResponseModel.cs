namespace CodedByKay.BondBridge.Models.Models.Requests
{
    public class UserResponseModel
    {
        public Guid UserId { get; set; }
        public string ImagePath { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        public ICollection<GroupResponseModel> Groups { get; set; } = new List<GroupResponseModel>();
    }
}
