namespace DotNetSocial.Models
{
    public class Post
    {
        public int postId { get; set; }
        public int userId { get; set; }
        public string? location { get; set; }
        public string caption { get; set; } = "";
    }
}