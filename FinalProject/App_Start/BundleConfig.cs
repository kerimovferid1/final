using System.Web;
using System.Web.Optimization;

namespace FinalProject
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Используйте версию Modernizr для разработчиков, чтобы учиться работать. Когда вы будете готовы перейти к работе,
            // ready for production, use the build tool at https://modernizr.com to pick onC:\Users\Ferid\documents\visual studio 2017\Projects\FinalProject\FinalProject\App_Start\BundleConfig.csly the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(

                      "~/publicFolder/jsh/bootstrap.js",
                      "~/publicFolder/jsh/script.js",
                      "~/publicFolder/jsh/jquery-3.2.0.js",
                      "~/publicFolder/plugin/owl.carousel.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/publicFolder/headercss/bootstrap.css",
                      "~/publicFolder/headercss/style.css",
                      "~/publicFolder/headercss/css/font-awesome.min.css"

                      ));

            bundles.Add(new StyleBundle("~/Content/plugInCss").Include(
                  "~/publicFolder/plugin/owl.carousel.min.css",
                   "~/publicFolder/plugin/owl.carousel.min.css",
                   "~/publicFolder/plugin/owl.theme.default.min.css"
                  ));
    
        }
    }
}











