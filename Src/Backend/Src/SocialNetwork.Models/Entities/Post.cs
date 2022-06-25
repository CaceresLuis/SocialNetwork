using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.Models.Entities
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public Guid IdUser { get; set; }
        public User User { get; set; }
    }
}
