using Athlitix.Data;
using Athlitix.Services;
using Athlitix.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

var dbContextOptionsBuilder = new DbContextOptionsBuilder<AthlitixContext>();
dbContextOptionsBuilder.UseSqlServer("Server=localhost;Database=admin_demo_db;Trusted_Connection=True;");

// Optionally, if you are using Dependency Injection:
builder.Services.AddDbContext<AthlitixContext>(options =>
    options.UseSqlServer("Server=localhost;Database=athlitix_db;User Id=sa;Password=sk8mccartney!;Trusted_Connection=True;TrustServerCertificate=True;"));

builder.Services.AddScoped<IAdminService, AdminService>();

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Create a scope to get the DbContext from DI
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AthlitixContext>();
    context.Database.EnsureCreated();
}


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
