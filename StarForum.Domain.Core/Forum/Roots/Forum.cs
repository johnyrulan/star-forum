namespace StarForum.Domain.Core.Forum.Roots
{
    public class Forum
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Thread[] Threads { get; set; }
    }
}
