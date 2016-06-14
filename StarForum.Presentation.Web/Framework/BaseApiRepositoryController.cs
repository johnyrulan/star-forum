using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace StarForum.Presentation.Web.Framework
{
    public class BaseApiRepositoryController : ApiController
    {
        protected ForumRepository _forumRepository { get; set; }
        public BaseRepositoryController()
        {
            _forumRepository = new ForumRepository();
        }
    }
}