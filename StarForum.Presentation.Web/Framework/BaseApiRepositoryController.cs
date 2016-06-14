using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using StarForum.Infrastructure.Data.Repositories;

namespace StarForum.Presentation.Web.Framework
{
    public class BaseApiRepositoryController : ApiController
    {
        protected ForumRepository _forumRepository { get; set; }
        public BaseApiRepositoryController()
        {
            _forumRepository = new ForumRepository();
        }
    }
}