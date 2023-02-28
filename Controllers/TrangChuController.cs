using System.Diagnostics;
using CayThue.Models;
using CayThue.Models.Accounts;
using Microsoft.AspNetCore.Mvc;

namespace CayThue.Controllers;

public class TrangChuController : Controller
{
    private readonly ILogger<TrangChuController> _logger;
    
    private IAccountRep _accountRep;

    public TrangChuController(ILogger<TrangChuController> logger, IAccountRep accountRep)
    {
        _logger = logger;
        _accountRep = accountRep;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    
    public IActionResult webcaythue()
    {
        _logger.LogInformation("webcaythue");
        IEnumerable<Account> accounts = _accountRep.GetAllAccounts();
        return View(accounts);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
