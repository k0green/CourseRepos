using CarPark.Interfaces;
using CarPark.Services;
using CarsParkDb.Interfaces;
using CarsParkDb;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<IDbContext, CarsStorageContext>();

builder.Services.AddScoped<IGetAllCarsService, GetAllCarsService>();
builder.Services.AddScoped<IUpdateCarService, UpdateCarService>();
builder.Services.AddScoped<ICreateCarService, CreateCarService>();
builder.Services.AddScoped<IDeleteCarService, DeleteCarService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=GetAll}");

app.Run();
