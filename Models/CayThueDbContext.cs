using Microsoft.EntityFrameworkCore;
using CayThue.Models.Accounts;
using CayThue.Models.AccountLolInfos;
using CayThue.Models.Users;
using CayThue.Models.Games;
using CayThue.Models.PaymentHistory;
using CayThue.Models.TradeHistory;
using Microsoft.EntityFrameworkCore.Design;

namespace CayThue.Models;

public class CayThueDbContext : DbContext
{
    public CayThueDbContext(DbContextOptions<CayThueDbContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //use this to configure the context
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //use this to configure the model
    }

    public DbSet<Account> Accounts { get; set; }
    
    public DbSet<AccountLolInfo> AccountLolInfos { get; set; }
    
    public DbSet<User> Users { get; set; }
    
    public DbSet<Game> Games { get; set; }
    
    public DbSet<Payment> PaymentHistory { get; set; }
    
    public DbSet<Trade> TradeHistory { get; set; }

}

public class CayThueDbContextFactory : IDesignTimeDbContextFactory<CayThueDbContext>
{
    public CayThueDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<CayThueDbContext>();
            
        Console.WriteLine("Khởi Tạo CayThueDbContextFactory");
            
        optionsBuilder.UseSqlite(
            "Data Source=" +
            Path.Combine(Directory.GetCurrentDirectory(), "mydb.db")
        );
            
        return new CayThueDbContext(optionsBuilder.Options);
    }
}