using System.Web.Mvc;
using StarForum.Domain.Core.Forum;
using StarForum.Presentation.Web.Areas.Forum.ViewModels;
using StarForum.Presentation.Web.Framework;

namespace StarForum.Presentation.Web.Areas.Forum.Controllers
{
    public class ForumController : BaseRepositoryController
    {
        public ActionResult Index()
        {
            var persistedThreads = _forumRepository.GetLatestThreads();

            var latestThreads = new Thread[4]
            {
                new Thread { Title = persistedThreads[0] }, 
                new Thread { Title = persistedThreads[1] }, 
                new Thread { Title = persistedThreads[2] }, 
                new Thread { Title = persistedThreads[3] }
            };

            return View(new IndexViewModel { LatestThreads = latestThreads });
        }

        //public JsonResult Latest()
        //{
        //    var latestPosts = _forumRepository.GetLatestThreads();

        //    return Json(latestPosts, JsonRequestBehavior.AllowGet);
        //}
    }
}