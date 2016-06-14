using System.Web.Mvc;
using StarForum.Presentation.Web.Framework;

namespace StarForum.Presentation.Web.Areas.Forum.Controllers
{
    public class ForumController : BaseRepositoryController
    {
        public ActionResult Index()
        {
            var latestPosts = _forumRepository.GetLatestThreads();
            return View(latestPosts);
        }
    }
}