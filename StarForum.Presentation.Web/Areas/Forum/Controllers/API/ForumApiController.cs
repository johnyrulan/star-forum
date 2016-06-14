using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StarForum.Presentation.Web.Framework;

namespace StarForum.Presentation.Web.Areas.Forum.Controllers.API
{
    public class ForumApiController : BaseApiRepositoryController
    {
        public IEnumerable<string> GetLatest()
        {
            return _forumRepository.GetLatestThreads();
        }

        // GET api/forumapi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/forumapi
        public void Post([FromBody]string value)
        {
        }

        // PUT api/forumapi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/forumapi/5
        public void Delete(int id)
        {
        }
    }
}
