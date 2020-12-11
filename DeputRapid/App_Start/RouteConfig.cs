using System.Web.Mvc;
using System.Web.Routing;

namespace DeputRapid
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "RegexNumerePare",
                url: "regex/ex3/{numar}",
                defaults: new { controller = "Exercitii", action = "ParsareRegex", numar = UrlParameter.Optional},
                constraints: new { nuamr = @"^\d{2,6}[02468]$"}
                );

            routes.MapRoute(
                name: "ContineCuvantOptional",
                url: "cautare/ex2/{cuvant}/{propozitie}",
                defaults: new { controller = "Exercitii", action = "CautareSubstringOptional", cuvant = UrlParameter.Optional, propozitie = UrlParameter.Optional}
                );

            routes.MapRoute(
                name: "ContineCuvant",
                url: "cautare/ex1/{cuvant}/{propozitie}",
                defaults: new { controller = "Exercitii", action = "CautareSubstring", cuvant = UrlParameter.Optional, propozitie = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            
        }
    }
}
