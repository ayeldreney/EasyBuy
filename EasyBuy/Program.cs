using EasyBuy.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region Services
builder.Services.AddControllersWithViews();
#endregion

#region DbContext Attaching
builder.Services.AddDbContext<EbContext>(options =>
	options.UseSqlServer(
		builder.Configuration.GetConnectionString("Default"),
		e => e.MigrationsAssembly(typeof(EbContext).Assembly.FullName)
	)
);
#endregion

var app = builder.Build();

/*
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
} 
*/

#region Authentication & Authorization

app.UseAuthentication();
app.UseAuthorization();

#endregion

#region Routing
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller}/{action=Index}/{id?}");

//app.MapFallbackToFile("index.html"); ;
#endregion


app.Run();