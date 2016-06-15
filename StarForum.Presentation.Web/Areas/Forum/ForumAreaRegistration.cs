using System.Web.Mvc;

namespace StarForum.Presentation.Web.Areas.Forum
{
    public class ForumAreaRegistration : AreaRegistration 
    {
        public override string AreaName { get { return "Forum"; } }

        public override void RegisterArea(AreaRegistrationContext context) 
        {        
            context.MapRoute(
                "ForumDefault",
                "Forum/{controller}/{action}/{id}",
                new { action = "Index", controller = "Forum", id = UrlParameter.Optional }
            );
        }
    }
}