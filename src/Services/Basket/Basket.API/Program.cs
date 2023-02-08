using Basket.API.Repositories;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Redis Configuration
builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = builder.Configuration.GetValue<string>("CacheSettings:ConnectionString");
});

// General Configuration
builder.Services.AddScoped<IBasketRepository, BasketRepository>();
//builder.Services.AddAutoMapper(typeof(Startup));

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Basket.API", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Basket.API v1"));
}

//var summaries = new[]
//{
//    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
//};

//app.MapGet("/weatherforecast", () =>
//{
//    var forecast = Enumerable.Range(1, 5).Select(index =>
//       new WeatherForecast
//       (
//           DateTime.Now.AddDays(index),
//           Random.Shared.Next(-20, 55),
//           summaries[Random.Shared.Next(summaries.Length)]
//       ))
//        .ToArray();
//    return forecast;
//})
//.WithName("GetWeatherForecast");

app.UseAuthorization();

app.MapControllers();

app.Run();

//internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
//{
//    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
//}