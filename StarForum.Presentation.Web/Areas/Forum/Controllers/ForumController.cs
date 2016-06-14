using System.Web.Mvc;
using StarForum.Presentation.Web.Framework;

namespace StarForum.Presentation.Web.Areas.Forum.Controllers
{
    public class ForumController : BaseRepositoryController
    {
        public JsonResult Latest()
        {
            var latestPosts = _forumRepository.GetLatestThreads();
            return Json(latestPosts, JsonRequestBehavior.AllowGet);
        }
    }
}