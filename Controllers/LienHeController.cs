using Microsoft.AspNetCore.Mvc;

namespace CayThue.Controllers;

public class LienHeController : Controller
{
    // GET
    public IActionResult lienhe()
    {
        return View();
    }
}