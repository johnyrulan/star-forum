using System.Web.Mvc;
using StarForum.Domain.Core.Forum;
using StarForum.Domain.Core.Forum.Roots;
using StarForum.Presentation.Web.Areas.Forum.ViewModels;
using StarForum.Presentation.Web.Framework;

namespace StarForum.Presentation.Web.Areas.Forum.Controllers
{
    public class ForumController : BaseRepositoryController
    {
        public ActionResult Index()
        {
            var persistedThreads = _forumRepository.GetLatestThreads();

            var latestThreads = new Thread[5]
            {
                new Thread { Title = persistedThreads[0] }, 
                new Thread { Title = persistedThreads[1] }, 
                new Thread { Title = persistedThreads[2] }, 
                new Thread { Title = persistedThreads[3] },
                new Thread { Title = persistedThreads[4] }
            };

            return View(new IndexViewModel { LatestThreads = latestThreads });
        }

        [HttpGet]
        public string CreatePost()
        {
            return "Hello!!";
        }

        [HttpPost]
        public ActionResult CreatePost(CreatePostViewModel post)
        {
            _forumRepository.AddNewPost(new Thread
            {
                Post = new Post(),
                Title = post.ThreadTitle
            });

            return RedirectToAction("Index");
        }


        //public JsonResult Latest()
        //{
        //    var latestPosts = _forumRepository.GetLatestThreads();

        //    return Json(latestPosts, JsonRequestBehavior.AllowGet);
        //}
    }
}