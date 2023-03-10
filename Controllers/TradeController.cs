using Microsoft.AspNetCore.Mvc;

namespace CayThue.Controllers;

public class TradeController : Controller
{
    // GET
    public IActionResult ViewGiaoDich()
    {
        return View();
    }
}