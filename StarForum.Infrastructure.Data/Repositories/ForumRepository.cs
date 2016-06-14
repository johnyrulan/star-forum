using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarForum.Infrastructure.Data.Repositories
{
    public class ForumRepository
    {
        public string[] GetLatestThreads()
        {
            return new string[] { "Need development help!", 
                                  "Can someone help me with this?",
                                  "JavaScript error!",
                                  "Where can I start learning?",
                                  "Looking for work..."};
        }
    }
}
