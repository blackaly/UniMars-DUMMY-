using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace UniMars.Models.Domains
{
    public class User : IdentityUser
    {
        [Required]
        [MaxLength(100, ErrorMessage = "The max length of the first name is 100 characters")]
        public string Name { get; set; }

        [MaxLength(200, ErrorMessage = "The max length of the first name is 100 characters")]
        public string Bio { get; set; }

    }
}
