using CayThue.Models;
using Microsoft.EntityFrameworkCore;
using CayThue.Models.Accounts;
using CayThue.Models.Users;

var builder = WebApplication.CreateBuilder(args);

var connectionString = "Data Source=" +
                       Path.Combine(Directory.GetCurrentDirectory(), "Data\\mydb.db");

// Add services to the container.
builder.Services.AddDbContext<CayThueDbContext>(optionsAction =>
    optionsAction.UseSqlite(connectionString)
);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IAccountRep, AccountRep>();
builder.Services.AddScoped<IUserRep, UserRep>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Index}/{id?}");

app.Run();