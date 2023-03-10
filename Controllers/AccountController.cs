using CayThue.Models.Accounts;
using CayThue.Models.Accounts.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace CayThue.Controllers;

/*
 * Manage Accounts to sell
 */
public class AccountController : Controller
{
    private readonly IStringLocalizer<AccountController> _localizer;
    
    private readonly IAccountRep _accountRep;
    
    public AccountController(
        IStringLocalizer<AccountController> localizer,
        IAccountRep accountRep
        )
    {
        _localizer = localizer;
        _accountRep = accountRep;
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
    
    [HttpPost]
    public IActionResult AccountCreate(CreateAccountViewModel model)
    {
        if (ModelState.IsValid)
        {
            Account account = new Account()
            {
                Id = Guid.NewGuid(),
                GameId = Guid.NewGuid(),
                Price = model.Price,
                Description = model.Description,
                UserId = "123",
                IsVerify = false,
                CanChangeInfo = false,
                IsSold = false,
                CreatedDate = DateTime.Now
            };
            _accountRep.AddAccount(account);
            return RedirectToAction("AccountList");
        }
        return View();
    }
}