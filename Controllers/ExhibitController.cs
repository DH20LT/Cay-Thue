using Microsoft.AspNetCore.Mvc;

namespace CayThue.Controllers
{
    public class ExhibitController : Controller
    {
        public IActionResult Exhibit()
        {
            return View();
        }
    }
}
