using StarForum.Domain.Core.Forum;
using StarForum.Domain.Core.Forum.Roots;

namespace StarForum.Presentation.Web.Areas.Forum.ViewModels
{
    public class IndexViewModel
    {
        public Thread[] LatestThreads { get; set; }
    }
}