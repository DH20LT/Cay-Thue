namespace CayThue.Models.TradeHistory;

public class TradeRep : ITradeRep
{
    private readonly ILogger<TradeRep> _logger;
    
    private readonly CayThueDbContext _cayThueDbContext;
    
    public TradeRep(CayThueDbContext cayThueDbContext,
        ILogger<TradeRep> logger
        )
    {
        _cayThueDbContext = cayThueDbContext;
        _logger = logger;
    }
    
    public void Add(Trade trade)
    {
        _cayThueDbContext.Trades.Add(trade);
        _cayThueDbContext.SaveChanges();
    }

    public void Delete(string id)
    {
        throw new NotImplementedException();
    }

    public void Update(Trade trade)
    {
        throw new NotImplementedException();
    }

    public Trade Find(string id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Trade> GetAll()
    {
        throw new NotImplementedException();
    }
}