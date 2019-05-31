using CMS.Models.Enums;

namespace CMS.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserTypeEnum UserType { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
    }
}