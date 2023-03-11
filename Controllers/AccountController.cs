using CayThue.Models.AccountLolInfos;
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

    private readonly IAccountLolInfoRep _accountLolInfoRep;

    public AccountController(
        IStringLocalizer<AccountController> localizer,
        IAccountRep accountRep,
        IAccountLolInfoRep accountLolInfoRep
    )
    {
        _localizer = localizer;
        _accountRep = accountRep;
        _accountLolInfoRep = accountLolInfoRep;
    }

    // GET
    public IActionResult AccountDetail(Guid Id)
    {
        Account account = _accountRep.GetAccountById(Id);
        AccountLolInfo accountLolInfo = _accountLolInfoRep.GetAccountLolInfoByAccountId(account.Id);
        DetailAccountViewModel detailAccountViewModel = new DetailAccountViewModel()
        {
            Id = "123",
            AccountId = account.Id,
            Price = account.Price,
            AvailableRiotPoints = accountLolInfo.AvailableRiotPoints,
            Level = accountLolInfo.Level,
            ProfileBanner = accountLolInfo.ProfileBanner,
            Honor = accountLolInfo.Honor,
            Server = accountLolInfo.Server,
            Champions = accountLolInfo.Champions,
            Skins = accountLolInfo.Skins,
            Chroma = accountLolInfo.Chroma,
            WardSkins = accountLolInfo.WardSkins,
            SumIcons = accountLolInfo.SumIcons,
            Emotes = accountLolInfo.Emotes,
            FlexDivision = accountLolInfo.FlexDivision
        };
        return View(detailAccountViewModel);
    }

    public IActionResult AccountList()
    {
        IEnumerable<Account> accounts = _accountRep.GetAllAccounts();
        return View(accounts);
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