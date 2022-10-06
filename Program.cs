using Microsoft.EntityFrameworkCore;
using SSLBooking.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<SSLBookingDbContext>(opts =>
{
    opts.UseSqlServer(
        builder.Configuration["ConnectionStrings:SSLBookingConnection"]);
});

builder.Services.AddScoped<ISSLBookingRepository, EFSSLBookingRepository>();

var app = builder.Build();

app.UseStaticFiles();

app.MapDefaultControllerRoute();

SeedData.EnsurePopulated(app);

app.Run();