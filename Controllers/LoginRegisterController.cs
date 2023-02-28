using Microsoft.AspNetCore.Mvc;

namespace CayThue.Controllers;

public class LoginRegisterController : Controller
{
    // GET
    public IActionResult index()
    {
        return View();
    }
}