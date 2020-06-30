using System.Web;
using System.Web.Optimization;

namespace SitioAdmin
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

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/AdminLTEcss").Include(
                     "~/Content/AdminLTE/css/bootstrap.css",
                     "~/Content/AdminLTE/css/font-awesome.css",
                     "~/Content/AdminLTE/css/ionicons.css",
                     "~/Content/AdminLTE/css/jquery-jvectormap-1.2.2.css",
                     "~/Content/AdminLTE/css/AdminLTE.css",
                     "~/Content/AdminLTE/css/_all-skins.css",
                     "~/Content/AdminLTE/css/jquery.gritter.css",
                     "~/Content/AdminLTE/css/bootstrap2-toggle.css",
                     "~/Content/AdminLTE/css/bootstrap-toggle.css"));

            bundles.Add(new ScriptBundle("~/Content/AdminLTEJs").Include(
                     "~/Content/AdminLTE/js/jQuery-2.2.0.min.js",
                     "~/Content/AdminLTE/js/bootstrap.js",
                     "~/Content/AdminLTE/Js/bootbox.min.js",
                     "~/Content/AdminLTE/Js/bootstrap-datepicker/bootstrap-datepicker.js",
                     "~/Content/AdminLTE/Js/jquery.dataTables.js",
                     "~/Content/AdminLTE/Js/dataTables.bootstrap.js",
                     "~/Content/AdminLTE/js/fastclick.js",
                     "~/Content/AdminLTE/js/app.js",
                     "~/Content/AdminLTE/js/jquery.sparkline.min.js",
                     "~/Content/AdminLTE/js/jquery-jvectormap-1.2.2.min.js",
                     "~/Content/AdminLTE/js/jquery-jvectormap-world-mill-en.js",
                     "~/Content/AdminLTE/js/jquery.slimscroll.min.js",
                     //"~/Content/AdminLTE/js/Chart.min.js",
                     //"~/Content/AdminLTE/js/dashboard2.js",
                     "~/Content/AdminLTE/Js/jquery.gritter.js",
                     "~/Scripts/jquery.form.js",
                     "~/Content/AdminLTE/js/demo.js",
                     "~/Scripts/General.js",
                     "~/Scripts/SpinnerModal.js",
                     "~/Scripts/SpinnerModalExtended.js",
                      "~/Content/AdminLTE/js/bootstrap2-toggle.js",
                      "~/Content/AdminLTE/js/bootstrap-toggle.js",
                      "~/Scripts/jquery.validate.js",
                      "~/Scripts/jquery.validate.unobtrusive.js"));
        }
    }
}
