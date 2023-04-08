using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Rent_a_Car.Models;
using Rent_a_Car.Data;
using Rent_a_Car;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<Rent_a_CarContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Rent_a_CarContext") ?? throw new InvalidOperationException("Connection string 'Rent_a_CarContext' not found.")));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services); // calling ConfigureServices method
startup.Configure(app, builder.Environment); // calling Configure method

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
