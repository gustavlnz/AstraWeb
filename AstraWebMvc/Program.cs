using Microsoft.EntityFrameworkCore;
using AstraWebMvc.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<SeedingService>();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AstraWebMvcContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("AstraWebMvcContext"),
        new MySqlServerVersion(new Version(8, 0, 45))
    )
);

var app = builder.Build();


// Configure the HTTP request pipeline. public void configurez
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
using (var scope = app.Services.CreateScope())
{
    var seedingService = scope.ServiceProvider.GetRequiredService<SeedingService>();
    seedingService.Seed();
}
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
