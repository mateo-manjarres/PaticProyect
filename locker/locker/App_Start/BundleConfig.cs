using System.Web;
using System.Web.Optimization;

namespace locker
{
    public class BundleConfig
    {
       
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
              
                        "~/Content/lib/jquery/jquery.min.js",
                         "~/Content/lib/jquery/jquery-migrate.min.js",
                         "~/Content/lib/bootstrap/js/bootstrap.bundle.min.js",
                          "~/Content/lib/easing/easing.min.js",
                         "~/Content/lib/superfish/hoverIntent.js",
                         "~/Content/lib/superfish/superfish.min.js",
                         "~/Content/lib/wow/wow.min.js",
                          "~/Content/lib/waypoints/waypoints.min.js",
                         "~/Content/lib/counterup/counterup.min.js",
                          "~/Content/lib/owlcarousel/owl.carousel.min.js",
                         "~/Content/lib/isotope/isotope.pkgd.min.js",
                          "~/Content/lib/lightbox/js/lightbox.min.js",
                          "~/Content/lib/touchSwipe/jquery.touchSwipe.min.js",
                          "~/Content/contactform/contactform.js",
                             "~/Content/js/main.js"
                        ));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
         


            bundles.Add(new StyleBundle("~/Content/css").Include(
            "~/url/https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,700,700i|Montserrat:300,400,500,700",
            "~/Content/lib/bootstrap/css/bootstrap.min.css",
              "~/Content/lib/font-awesome/css/font-awesome.min.css",
              "~/Content/lib/animate/animate.min.css",
               "~/Content/lib/ionicons/css/ionicons.min.css",
              "~/Content/lib/owlcarousel/assets/owl.carousel.min.css",
              "~/Content/lib/lightbox/css/lightbox.min.css",
             "~/Content/css/style.css"));
        }
    }
}
