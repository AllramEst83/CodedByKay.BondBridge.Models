using System.ComponentModel.DataAnnotations;

namespace CodedByKay.BondBridge.Models.Models.Requests
{
    public class MessageRequestModel
    {
        [Required(ErrorMessage = "GroupId cannot be default Guid value.")]
        public Guid GroupId { get; set; }

        [Required(ErrorMessage = "SenderId cannot be default Guid value.")]
        public Guid SenderId { get; set; }

        [Required(ErrorMessage = "Message content is required.")]
        [StringLength(1000, ErrorMessage = "Message content cannot exceed 1000 characters.")]
        public string Content { get; set; }
    }
}
