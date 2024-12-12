using VP_Lifestyle.Data;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

///Add services
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ILifestyleRepository, LifestyleRepository>();

//Database Option 1 :SQl Server
builder.Services.AddDbContext<LifestyleDbContext>(options =>
     options.UseSqlServer(builder.Configuration.GetConnectionString("VPConnection")));

//Database option 2: SQL Lite Server
//builder.Services.AddDbContext<AppDbContext>(options =>
//       options.UseSqlite(builder.Configuration.GetConnectionString("VPConnection")));

builder.Services.AddRouting(options =>
{
   options.LowercaseUrls = true;
   options.AppendTrailingSlash = true;
});
var app = builder.Build();

//configure the HTTP request pipeline
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
    name: default,
    pattern: "{controller=Restoran}/{action=Index}/{id?}"
    );
SeedData.EnsurePopulated(app);
app.Run();
