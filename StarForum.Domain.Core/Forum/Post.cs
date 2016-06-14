namespace StarForum.Domain.Core.Forum
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public string AuthorEmail { get; set; }
        public Post[] Replies { get; set; }
        public int ReplyCount { get; set; }
    }
}
