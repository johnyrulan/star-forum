namespace StarForum.Domain.Core.Forum.Roots
{
    public class Thread
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Post Post { get; set; }
    }
}
