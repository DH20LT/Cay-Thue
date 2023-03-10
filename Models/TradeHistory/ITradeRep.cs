namespace CayThue.Models.TradeHistory;

public interface ITradeRep
{
    void Add(Trade trade);
    
    void Delete(string id);
    
    void Update(Trade trade);
    
    Trade Find(string id);
    
    IEnumerable<Trade> GetAll();
    
}