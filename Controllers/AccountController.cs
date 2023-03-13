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
    
    private readonly ILogger<AccountController> _logger;

    public AccountController(
        IStringLocalizer<AccountController> localizer,
        IAccountRep accountRep,
        IAccountLolInfoRep accountLolInfoRep,
        ILogger<AccountController> logger
    )
    {
        _localizer = localizer;
        _accountRep = accountRep;
        _accountLolInfoRep = accountLolInfoRep;
        _logger = logger;
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

        _accountRep.IncreaseViews(Id);
        
        return View(detailAccountViewModel);
    }

    public IActionResult AccountList()
    {
        IEnumerable<Account> accountList = _accountRep.GetAllAccounts();
        
        accountList.ToList().ForEach(account => _logger.LogInformation("Account: {0}", account.toString()));
        
        

        IEnumerable<AccountLolInfo> accountLolInfoList = _accountLolInfoRep.GetAllAccountLolInfos();
        
        accountLolInfoList.ToList().ForEach(accountLolInfo => _logger.LogInformation("AccountLolInfo: {0}", accountLolInfo.toString()));
        
        
        IEnumerable<ListAccountViewModel> accountViewModelList;
        
        accountViewModelList = accountList.Join(
            accountLolInfoList,
            account => account.Id,
            accountLolInfo => accountLolInfo.AccountId,
            (account, accountLolInfo) => new ListAccountViewModel()
            {
                AccountId = account.Id,
                Price = account.Price,
                AvailableRiotPoints = accountLolInfo.AvailableRiotPoints ?? "0",
                Level = accountLolInfo.Level ?? "0",
                Champions = accountLolInfo.Champions,
                Skins = accountLolInfo.Skins,
                Chromas = accountLolInfo.Chroma,
                WardSkins = accountLolInfo.WardSkins,
                SumIcons = accountLolInfo.SumIcons,
                Emotes = accountLolInfo.Emotes,
            }
        );

        accountViewModelList.ToList().ForEach(accountViewModelList => _logger.LogInformation("ListAccountViewModel: {0}", accountViewModelList.toString()));
        
        return View(accountViewModelList);
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
            
            AccountLolInfo accountLolInfo = new AccountLolInfo()
            {
                AccountId = account.Id,
                AvailableRiotPoints = "0",
                Level = "0",
                Honor = "0",
                Champions = "0",
                Skins = "0",
                Chroma = "0",
                WardSkins = "0",
                SumIcons = "0",
                Emotes = "0"
            };
            _accountLolInfoRep.Add(accountLolInfo);
            
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
                // AccountLolInfo = accountLolInfo
            }
        );
        
        return accountsWithLolInfo;
    }
}