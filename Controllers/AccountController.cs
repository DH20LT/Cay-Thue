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
            AccountId = Guid.NewGuid(),
            Price = account?.Price ?? 0,
            AvailableRiotPoints = accountLolInfo?.AvailableRiotPoints ?? "0",
            Level = accountLolInfo?.Level ?? "0",
            Honor = accountLolInfo?.Honor ?? "0",
            Champions = accountLolInfo?.Champions ?? "0",
            Skins = accountLolInfo?.Skins ?? "0",
            Chromas = accountLolInfo?.Chroma ?? "0",
            WardSkins = accountLolInfo?.WardSkins ?? "0",
            SumIcons = accountLolInfo?.SumIcons ?? "0",
            Emotes = accountLolInfo?.Emotes ?? "0",
        };
        return View(detailAccountViewModel);
    }

    public IActionResult AccountList()
    {
        List<Account> accountList = _accountRep.GetAccountList();

        List<AccountViewModel> accountViewModelList = new ArrayList<AccountViewModel>();
        
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

    IEnumerable<Account> GetAllAccountsWithLolInfo() {
        IEnumerable<Account> accounts = _accountRep.GetAllAccounts();
        IEnumerable<AccountLolInfo> accountLolInfos = _accountLolInfoRep.GetAllAccountLolInfos();

        IEnumerable<Account> accountsWithLolInfo = accounts.Join(
            accountLolInfos,
            account => account.Id,
            accountLolInfo => accountLolInfo.AccountId,
            (account, accountLolInfo) => new Account()
            {
                Id = account.Id,
                GameId = account.GameId,
                Price = account.Price,
                Description = account.Description,
                UserId = account.UserId,
                IsVerify = account.IsVerify,
                CanChangeInfo = account.CanChangeInfo,
                IsSold = account.IsSold,
                CreatedDate = account.CreatedDate,
                AccountLolInfo = accountLolInfo
            }
        );
        
        return accountsWithLolInfo;
    }
}