namespace DotNetSocial.Models
{
    public class Comment
    {
        public int commentId { get; set; }
        public int postId { get; set; }
        public int commenter { get; set; }
        public string comment { get; set; } = "";
        public int parentCommentId { get; set; }

    }
}