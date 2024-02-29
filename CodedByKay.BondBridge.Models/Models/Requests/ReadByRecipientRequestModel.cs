using System.ComponentModel.DataAnnotations;

namespace CodedByKay.BondBridge.Models.Models.Requests
{
    public class ReadByRecipientRequestModel
    {
        [Required(ErrorMessage = "MessageId is required.")]
        public Guid MessageId { get; set; }

        [Required(ErrorMessage = "UserId is required.")]
        public Guid UserId { get; set; }
    }

}
