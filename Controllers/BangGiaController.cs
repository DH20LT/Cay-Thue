using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CayThue.Models;

namespace CayThue.Controllers;

public class BangGiaController : Controller
{
    private readonly ILogger<BangGiaController> _logger;

    public BangGiaController(ILogger<BangGiaController> logger)
    {
        _logger = logger;
    }
    
    public IActionResult BangGia()
    {
        _logger.LogInformation("BangGia");
        return View();
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}