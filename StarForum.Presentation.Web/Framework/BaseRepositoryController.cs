using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StarForum.Presentation.Web.Framework
{
    public class BaseRepositoryController : Controller
    {
        protected ForumRepository _forumRepository { get; set; }
        public BaseRepositoryController() : base()
        {
            _forumRepository = new ForumRepository();
        }
    }
}