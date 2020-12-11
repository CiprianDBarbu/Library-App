using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeputRapid.Controllers
{
    public class ExercitiiController : Controller
    {
        // GET: Exercitii
        public ActionResult Index()
        {
            return View();
        }

        public ContentResult CautareSubstring(string cuvant, string propozitie)
        {
            string mesaj = $"Propozitia {propozitie} contine cuvantul {cuvant}";
            string mesajEroare = $"Propozitia {propozitie} NU contine cuvantul {cuvant}";
            string mesajEroare2 = "Lipseste un parametru!";

            if(!string.IsNullOrEmpty(propozitie) && !string.IsNullOrEmpty(cuvant))
            {
                if(propozitie.Contains(cuvant))
                {
                    return Content(mesaj);
                }
                return Content(mesajEroare);
            }
            return Content(mesajEroare2);
        }

        public ActionResult CautareSubstringOptional(string cuvant, string? propozitie)
        {
            ViewBag.message = $"Propozitia '{propozitie}' contine cuvantul '{cuvant}'";

            if(string.IsNullOrEmpty(propozitie))
            {
                return HttpNotFound("Parametrul propozitie lipseste!");
            }
            if(!propozitie.Contains(cuvant))
            {
                ViewBag.message = $"Propozitia '{propozitie}' NU contine cuvantul '{cuvant}'";
            }
            return View();
        }


        public string ParsareRegex(int? numar)
        {
            return $"Numarul introdus este :{numar}";
        }
    }
}