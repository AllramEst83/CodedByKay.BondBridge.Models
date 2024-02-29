using System.ComponentModel.DataAnnotations;

namespace CodedByKay.BondBridge.Models.Models.Requests
{
    public class UserRequestModel
    {
        public string ImagePath { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        [StringLength(50, ErrorMessage = "Username cannot exceed 50 characters.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }

        public ICollection<Guid> GroupIds { get; set; } = new List<Guid>();
    }
}
