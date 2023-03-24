using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using UniMars.Models.Enums;

namespace UniMars.Models.Domains
{
    public class User : IdentityUser
    {
        [Required]
        [MaxLength(100, ErrorMessage = "The max length of the first name is 100 characters")]
        public string Name { get; set; }

        [MaxLength(200, ErrorMessage = "The max length of the first name is 100 characters")]
        public string Bio { get; set; }
        [MaxLength(200)]
        public string ProfilePicture { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public Gender Gender { get; set; }
        public bool Status { get; set; }

    }
}
