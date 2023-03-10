using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace CayThue.Controllers;

/*
 * Manage Accounts to sell
 */
public class AccountController : Controller
{
    private readonly IStringLocalizer<AccountController> _localizer;
    
    public AccountController(IStringLocalizer<AccountController> localizer)
    {
        _localizer = localizer;
    }
    
    // GET
    public IActionResult AccountDetail()
    {
        return View();
    }
    
    public IActionResult AccountList()
    {
        return View();
    }
    
    [HttpGet]
    public IActionResult AccountCreate()
    {
        return View();
    }
}