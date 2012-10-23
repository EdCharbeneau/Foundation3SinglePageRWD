using System.Web;
using System.Web.Optimization;

namespace Foundation3SinglePageRWD
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            #region Foundation Bundles
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                       "~/Scripts/foundation/modernizr.foundation.js.*"));

            bundles.Add(new StyleBundle("~/Content/foundation/css").Include(
                       "~/Content/foundation/foundation.css",
                       "~/Content/foundation/app.css"));

            bundles.Add(new ScriptBundle("~/bundles/foundation").Include(
                      "~/Scripts/foundation/jquery.*",
                      "~/Scripts/foundation/app.js"));
            #endregion
        }
    }
}