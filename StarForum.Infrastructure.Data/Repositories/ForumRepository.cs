using StarForum.Domain.Core.Forum.Roots;

namespace StarForum.Infrastructure.Data.Repositories
{
    public class ForumRepository
    {
        public string[] GetLatestThreads()
        {
            return new string[] { "Need development help!", 
                                  "Can someone help me with this?",
                                  "JavaScript error!",
                                  "Where can I start learning?",
                                  "Looking for work...",
                                  "Sample post"};
        }

        public void AddNewPost(Thread thread)
        {
            throw new System.NotImplementedException();
        }
    }
}
