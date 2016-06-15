using System.Collections.Generic;
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

        public string Get(int id)
        {
            return "value";
        }

        public void Post([FromBody]string value)
        {
        }

        public void Put(int id, [FromBody]string value)
        {
        }

        public void Delete(int id)
        {
        }
    }
}
