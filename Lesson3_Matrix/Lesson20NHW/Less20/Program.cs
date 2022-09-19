using Less20.Middlware;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors();
app.UseMiddleware<TokenMiddleware>();
app.UseAuthentication();
app.UseAuthorization();
app.UseHsts();

app.Run();
