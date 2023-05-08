using System.ComponentModel.DataAnnotations;

namespace OneToManyWebAPI.Models
{
    public class UserInfo
    {
        [Key]
        public int UserId { get; set; }
        public string? UserName { get; set; }

        public string UserEmail { get; set; }
        public string Password { get; set; }
    }
}
