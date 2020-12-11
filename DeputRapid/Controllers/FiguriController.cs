using DeputRapid.Models;
using System.Web.Mvc;

namespace DeputRapid.Controllers
{
    public class FiguriController : Controller
    {
        // GET: Figuri
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Prima()
        {
            Figura f = new Figura
            {
                Nume = "cerc"
            };
            return View(f);
        }
    }
}