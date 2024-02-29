using CodedByKay.BondBridge.Models.Attributes;
using System.ComponentModel.DataAnnotations;

namespace CodedByKay.BondBridge.Models.Models.Requests
{
    public class GroupRequestModel
    {
        [NotDefaultGuid(ErrorMessage = "GroupId cannot be default Guid value.")]
        public Guid? GroupId { get; set; }

        [Required(ErrorMessage = "GroupName is required.")]
        [StringLength(100, ErrorMessage = "GroupName cannot exceed 100 characters.")]
        public string GroupName { get; set; }

        public ICollection<Guid> MemberIds { get; set; }
    }
}
