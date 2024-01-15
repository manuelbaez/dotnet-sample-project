using Microsoft.EntityFrameworkCore;
using DataAccess.Contexts;
using BusinessLogic.Configuration.Mapper;
using BusinessLogic.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<LibraryContext>(x => x.UseLazyLoadingProxies()
                                                    .UseSqlite(builder.Configuration.GetConnectionString("LibraryDB")));
builder.Services.ConfigureRepositories();
builder.Services.ConfigureMappings();
builder.Services.ConfigureServices();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
