using System.ComponentModel.DataAnnotations;

namespace Goodreads.Models
{
    public class RegisterViewModel
    {
        [Required, MaxLength(256)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
