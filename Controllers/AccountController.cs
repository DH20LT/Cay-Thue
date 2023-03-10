using Microsoft.AspNetCore.Mvc;

namespace CayThue.Controllers;

public class AccountController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult AccountList()
    {
        return View();
    }
}