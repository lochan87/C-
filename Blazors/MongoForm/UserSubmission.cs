using System.ComponentModel.DataAnnotations;

namespace MongoForm.Models
{
    public class UserSubmission
    {
        public MongoDB.Bson.ObjectId Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; } = "";
    }
}
