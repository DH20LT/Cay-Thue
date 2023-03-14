using CayThue.Models.Accounts;
using CayThue.Models.TradeHistory;
using CayThue.Models.TradeHistory.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CayThue.Controllers;

public class TradeController : Controller
{
    private readonly ILogger<TradeController> _logger;
    
    private readonly ITradeRep _tradeRep;
    
    private readonly IAccountRep _accountRep;
    
    public TradeController(
        ITradeRep tradeRep,
        ILogger<TradeController> logger,
        IAccountRep accountRep
    )
    {
        _tradeRep = tradeRep;
        _logger = logger;
        _accountRep = accountRep;
        _logger.LogInformation("TradeController Created");
    }
    
    /**
     * Open View GiaoDich
     *
     */
    public IActionResult GiaoDich(Guid? accountId)
    {
        _logger.LogInformation("GiaoDich");
        
        var seller = _accountRep.GetUserByAccountId(accountId ?? Guid.Empty);
        
        var account = _accountRep.GetAccountById(accountId ?? Guid.Empty);

        Trade trade = new Trade()
        {
            Id = Guid.NewGuid(),
            AccountId = accountId ?? Guid.Empty,
            BuyerId = Guid.Empty, // Is Id of Current User
            SellerId = seller.Id, // Is Id of Account Owner
            Status = 0,
            CreatedDate = DateTime.Now,
        };
        _tradeRep.Add(trade);
        
        GiaoDichViewModel giaoDichViewModel = new GiaoDichViewModel()
        {
            Trade = trade,
            Account = account
        };

        return View(giaoDichViewModel);
    }
}