using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.Models.Entities
{
    public class User : IdentityUser
    {
        [MaxLength(200, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Name { get; set; }
        public string Picture { get; set; }
        [MaxLength(500, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Address { get; set; }
    }
}
