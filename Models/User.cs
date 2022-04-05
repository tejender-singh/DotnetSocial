namespace DotNetSocial.Models
{
    public class User
    {
        public int userId { get; set; }
        public string password { get; set; } = "";
        public string email { get; set; } = "";
        public string? contact { get; set; }
        public bool isPublicProfile { get; set; }
        public bool active { get; set; }
    }
}