using Microsoft.AspNetCore.Mvc;

namespace CayThue.Controllers;

public class NapTheController : Controller
{
    // GET
    public IActionResult napthe()
    {
        return View();
    }
}