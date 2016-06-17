using System.Web.Optimization;

namespace StarForum.Presentation.Web.Configuration
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Assets/Libraries/jQuery/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Assets/Libraries/jQuery/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Assets/Libraries/Modernizr/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Assets/Libraries/Bootstrap/bootstrap.js",
                      "~/Assets/Libraries/RespondJS/respond.js"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/Assets/Libraries/Bootstrap/bootstrap.css",
                      "~/Assets/Styles/Site.css"));

            bundles.Add(new StyleBundle("~/bundles/customcss").Include(
                      "~/Assets/Styles/Header.css"));
        }
    }
}
