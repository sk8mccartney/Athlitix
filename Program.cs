using Athlitix.Configuration;
using Athlitix.Data;
using Athlitix.Entities;
using Athlitix.Models;
using Athlitix.Services;
using Athlitix.Services.Interfaces;
using Athlitix.Utilities.Mappers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Bind the "Security" section of appsettings.json
builder.Services.Configure<SecuritySettings>(builder.Configuration.GetSection("Security"));

// Optionally, if you are using Dependency Injection:
builder.Services.AddDbContext<AthlitixContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IMapper<AdminEntity, AdminModel>, AdminMapper>();
builder.Services.AddScoped<IMapper<CompetitionEntity, CompetitionModel>, CompetitionMapper>();
builder.Services.AddScoped<IMapper<EventTypeEntity, EventTypeModel>, EventTypeMapper>();
builder.Services.AddScoped<IMapper<OrganizationEntity, OrganizationModel>, OrganizationMapper>();
builder.Services.AddScoped<IAdminService, AdminService>();
builder.Services.AddScoped<IOrganizationService, OrganizationService>();

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