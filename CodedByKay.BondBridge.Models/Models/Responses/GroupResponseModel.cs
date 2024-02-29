using CodedByKay.BondBridge.Models.Models.Responses;

namespace CodedByKay.BondBridge.Models.Models.Requests
{
    public class GroupResponseModel
    {
        public Guid GroupId { get; set; }
        public string GroupName { get; set; }

        public ICollection<UserSimpleResponseModel> Members { get; set; } = new List<UserSimpleResponseModel>();
    }
}
