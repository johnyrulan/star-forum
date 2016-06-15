using System.Web.Mvc;
using StarForum.Infrastructure.Data.Repositories;

namespace StarForum.Presentation.Web.Framework
{
    public class BaseRepositoryController : Controller
    {
        protected ForumRepository _forumRepository { get; set; }
        public BaseRepositoryController()
        {
            _forumRepository = new ForumRepository();
        }
    }
}