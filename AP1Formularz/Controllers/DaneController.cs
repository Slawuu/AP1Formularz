using Microsoft.AspNetCore.Mvc;
using AP1Formularz.Models;

namespace AP1Formularz.Controllers
{
    public class DaneController : Controller
    {
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(Dane dane)
        {
            if (ModelState.IsValid)
            {
                return View("Wynik", dane);
            }
            else
            {
                return View(dane);
            }
        }

        public IActionResult Wynik(Dane dane)
        {
            return View(dane);
        }
    }
}
