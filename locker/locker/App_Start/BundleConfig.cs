using System.Web;
using System.Web.Optimization;

namespace locker
{
    public class BundleConfig
    {

        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                            "~/Content/js/jquery-1.10.2.js",
                            "~/Content/js/jquery-ui-1.10.4.custom.min.js",
                            "~/Content/js/bootstrap.js",
                            "~/Content/js/awesome-landing-page.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                          "~/Content/css/bootstrap.css",
                          "~/Content/css/landing-page.css",
                          "~/Content/css/pe-icon-7-stroke.css"));
            


        }
    }
}
