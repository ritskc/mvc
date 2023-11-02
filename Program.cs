using Microsoft.EntityFrameworkCore;
using mvc.Models;
using mvc.Repository.IRepository;
using mvc.Repository.MockRepository;
using mvc.Repository.SQLRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContextPool<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("EmployeeDBConnection")));
builder.Services.AddScoped<IEmployeeRepository,SQLEmployeeRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStatusCodePagesWithRedirects("/Error/{0}");
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
