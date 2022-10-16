using Microsoft.EntityFrameworkCore;
using SSLBooking.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DataContext>(opts =>
{
    opts.UseSqlServer(
        builder.Configuration["ConnectionStrings:SSLBookingConnection"]);
    opts.EnableSensitiveDataLogging(true);
});

var app = builder.Build();

app.UseStaticFiles();

app.MapDefaultControllerRoute();

var context = app.Services.CreateScope().ServiceProvider
    .GetRequiredService<DataContext>();
SeedData.SeedDatabase(context);

app.Run();