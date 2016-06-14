using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StarForum.Presentation.Web.Areas.Forum.Controllers
{
    public class ForumController : Controller
    {
        private ForumRepository _forumRepository { get; set; }

        public ForumController()
        {
            _forumRepository = new ForumRepository();
        }

        public string Index()
        {
            var latestPosts = _forumRepository.GetLatestThreads();
            return View(latestPosts);
        }
	}
}